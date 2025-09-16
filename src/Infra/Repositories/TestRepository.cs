using Core.Repositories;
using Domain.Entities;
using Infra.Contexts;

namespace Infra.Repositories
{
    public interface ITestRepository : IGenericRepository<Test>
    {

    }

    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        public TestRepository(CmxDBContext dbContext) : base(dbContext)
        {
        }

    }
}
