using Application.Interfaces;

namespace Shared.Services
{
    public class DatetimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}