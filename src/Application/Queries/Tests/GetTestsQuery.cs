using Application.Models.Params.Tests;
using Core.Extensions;
using Core.Models;
using FluentValidation;
using Infra;
using Infra.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Queries.Tests
{
    public class GetTestsQuery : IRequest<PagedResponse<IReadOnlyList<object>>>
    {
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
        public bool IsActiveFilter { get; set; }
        public int? LevelFilter { get; set; }
    }

    public class GetTestsQueryHandler : IRequestHandler<GetTestsQuery, PagedResponse<IReadOnlyList<object>>>
    {
        private readonly DBReadDbContext _dbRead;

        public GetTestsQueryHandler(DBReadDbContext dbRead
            )
        {
            _dbRead = dbRead;
        }

        public async Task<PagedResponse<IReadOnlyList<object>>> Handle(GetTestsQuery query, CancellationToken cancellationToken)
        {
            //mapping thay cho automapper
            var validFilter = GeneralMapping.Map<GetTestsQuery, TestParams>(query);

            //get tu db
            var rs = await _dbRead.ConsumerdbMasterDetails.AsNoTracking().ToListAsync();
            //return await _repository.GetModelPagedReponseAsync<TestParams, TestModel>(validFilter);
            return new()
            {
                Success = true,
                UnAuthorizedRequest = false,
                Result = new PagedResult<IReadOnlyList<object>>
                {
                    TotalCount = rs.Count,
                    Items = GeneralMapping.Map<List<ConsumerdbMasterDetail>, List<object>>(rs)
                }
            };
        }
    }

    public class GetTestsQueryValidator : AbstractValidator<GetTestsQuery>
    {
        public GetTestsQueryValidator()
        {
            RuleFor(x => x.IsActiveFilter)
                .NotEmpty().WithMessage("IsActiveFilter is required");
        }
    }
}
