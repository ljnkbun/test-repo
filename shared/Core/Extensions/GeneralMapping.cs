using System.Collections;
using System.Reflection;

namespace Core.Extensions
{
    public class GeneralMapping
    {
        public static TDestination Map<TSource, TDestination>(TSource source)
        where TDestination : class, new()
        {
            return (TDestination)MapInternal(source, typeof(TDestination), new HashSet<object>());
        }

        private static object MapInternal(object source, Type destinationType, HashSet<object> visited)
        {
            if (source == null) return null;
            if (visited.Contains(source)) return null; // chống loop
            visited.Add(source);

            var srcType = source.GetType();

            // Nếu primitive / string → trả thẳng
            if (srcType.IsPrimitive || srcType.IsEnum || srcType == typeof(string) || srcType == typeof(decimal))
                return source;

            // Nếu collection
            if (typeof(IEnumerable).IsAssignableFrom(destinationType) && destinationType.IsGenericType)
            {
                var destList = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(destinationType.GetGenericArguments()[0]));
                foreach (var item in (IEnumerable)source)
                {
                    destList.Add(MapInternal(item, destinationType.GetGenericArguments()[0], visited));
                }
                return destList;
            }

            // Nếu object phức tạp
            var destination = Activator.CreateInstance(destinationType);
            var srcProps = srcType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var destProps = destinationType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var dProp in destProps)
            {
                var sProp = srcProps.FirstOrDefault(p => p.Name == dProp.Name);
                if (sProp == null || !dProp.CanWrite) continue;

                var sValue = sProp.GetValue(source, null);
                if (sValue == null)
                {
                    dProp.SetValue(destination, null);
                    continue;
                }

                if (dProp.PropertyType == sProp.PropertyType)
                {
                    dProp.SetValue(destination, sValue);
                }
                else
                {
                    var mappedValue = MapInternal(sValue, dProp.PropertyType, visited);
                    dProp.SetValue(destination, mappedValue);
                }
            }

            return destination;
        }
    }
}
