using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MinhaAppVS
{
    public class MeuMiddleware
    {

        private readonly RequestDelegate _next;

        public MeuMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("\n\r ------ Antes ------ \n\r");

            await _next(context);

            Console.WriteLine("\n\r ------ Depois ------ \n\r");
        }
    }

    public static class MeuMiddlewareExtension
    {

        public static IApplicationBuilder UseMeuMiddleware(this IApplicationBilder builder)
        {
            return builder.UseMeuMiddleware<MeuMiddleware>();
        }
    }
}
