using IbnMasjjed.Api.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbnMasjjed.Api.Middleware
{
    public class ApiSecurityMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;

        public ApiSecurityMiddleware(RequestDelegate next, AppSettings appSettings)
        {
            _next = next;
            _appSettings = appSettings;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            var key = context.Request.Headers["x-api-key"];

            if (string.IsNullOrWhiteSpace(key) || !key.Equals(_appSettings.Security.ApiKey))
            {
                context.Response.StatusCode = 401;
            }
            else
            {
                // Call the next delegate/middleware in the pipeline
                await _next(context);
            }

        }
    }
}
