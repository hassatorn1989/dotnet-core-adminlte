using System;

namespace PjAdminlte.Middlewares;

public class CustomMiddleware
{
    private readonly RequestDelegate _next;

    public CustomMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // แสดงข้อมูล Path ของคำขอ
        Console.WriteLine("Request Path: " + context.Request.Path);
        // ส่งคำขอต่อไปยัง middleware ถัดไป
        await _next(context);
    }
}
