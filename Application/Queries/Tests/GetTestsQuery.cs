using Application.Models.Params.Tests;
using Application.Models.Responses;
using Core.Extensions;
using Core.Models;
using Infra.Repositories;
using MediatR;

namespace Application.Queries.Tests
{
    public class GetTestsQuery : IRequest<PagedResponse<IReadOnlyList<TestModel>>>
    {
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
        public bool IsActiveFilter { get; set; }
        public int? LevelFilter { get; set; }
    }

    public class GetTestsQueryHandler : IRequestHandler<GetTestsQuery, PagedResponse<IReadOnlyList<TestModel>>>
    {
        private readonly ITestRepository _repository;

        public GetTestsQueryHandler(ITestRepository repository
            )
        {
            _repository = repository;
        }

        public async Task<PagedResponse<IReadOnlyList<TestModel>>> Handle(GetTestsQuery query, CancellationToken cancellationToken)
        {
            var validFilter = GeneralMapping.Map<GetTestsQuery, TestParams>(query);

            //return await _repository.GetModelPagedReponseAsync<TestParams, TestModel>(validFilter);
            return new();


        }
    }
}
