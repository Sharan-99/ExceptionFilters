using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionFilters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly ILoggerManager _logger;
        public CustomExceptionFilter(ILoggerManager logger)
        {
            _logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            _logger.LogInformation(context.Exception.Message);
        }
    }
}
