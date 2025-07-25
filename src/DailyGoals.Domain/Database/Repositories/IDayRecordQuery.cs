using DailyGoals.Shared.Models;
using DailyGoals.Shared.Models.Handlers.Queries;

namespace DailyGoals.Domain.Database.Repositories
{
    public interface IDayRecordQuery : IQuery
    {
        Task<bool> CheckIfCalendarWasGeneratedAsync();
        Task<int> GetDaysLengthToEndAsync();
        Task<IEnumerable<DayRecordCollectionModel>> GetAllDayRecordsAsync();
    }
}
