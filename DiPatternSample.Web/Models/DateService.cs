using System;
using Microsoft.Extensions.Logging;

namespace DiPatternSample.Web
{
    public class DateService : ISingletonDateService,IScopedDateService,ITransientDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;
            _logger.LogWarning("Dateservice constructer'ına girdi!");
        }
        public DateTime GetDateTime {get;} = DateTime.Now;
    }
}