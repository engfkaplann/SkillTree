using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.Middleware.Middlewares
{
    public class CustomMiddlewareA
    {
        private readonly RequestDelegate _next;

        public CustomMiddlewareA(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            // Middleware operations are performed here
            var className = this.GetType().Name;

            Console.WriteLine($"Middleware {className} invoked");

            var existingValue = context.Response.Headers["CustomHeader"];
            context.Response.Headers["CustomHeader"] = existingValue + className + "-";

            // Moving to the next Middleware component
            await _next(context);

            // Performed after response is received
            Console.WriteLine($"Middleware {className} invoked");
        }
    }
}
