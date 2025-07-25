using MediatR;
using DailyGoals.Shared.Models;

namespace DailyGoals.Shared.Models.Handlers.Queries;
public record GetAllDayRecordsAsyncQuery : IRequest<IEnumerable<DayRecordCollectionModel>>;
