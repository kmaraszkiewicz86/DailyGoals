using MediatR;
using DailyGoals.Domain.Database.Repositories;
using DailyGoals.Domain.Models;
using DailyGoals.Shared.Models.Handlers.Queries;

namespace DailyGoals.ApplicationLayer.Handlers.Queries
{
    public class GetAllDayRecordsAsyncQueryCommand(IDayRecordQuery databaseQuery) : IRequestHandler<GetAllDayRecordsAsyncQuery, IEnumerable<DayRecordCollectionModel>>
    {
        public Task<IEnumerable<DayRecordCollectionModel>> Handle(GetAllDayRecordsAsyncQuery request, CancellationToken cancellationToken)
        {
            return databaseQuery.GetAllDayRecordsAsync();
        }
    }
}
