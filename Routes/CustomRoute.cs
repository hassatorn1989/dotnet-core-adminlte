using System;

namespace PjAdminlte.Routes;

public class CustomRoute
{
    public static void RegisterRoutes(IEndpointRouteBuilder endpoints)
    {

        endpoints.MapControllerRoute(
            name: "default",
            pattern: "",
            defaults: new { controller = "Authen", action = "Index" });

        endpoints.MapControllerRoute(
            name: "authen.login",
            pattern: "login",
            defaults: new { controller = "Authen", action = "Login" });

        endpoints.MapControllerRoute(
            name: "authen.register",
            pattern: "/register",
            defaults: new { controller = "Authen", action = "Register" });

        endpoints.MapControllerRoute(
            name: "authen.register-store",
            pattern: "register-store",
            defaults: new { controller = "Authen", action = "RegisterStore" });
    }
}
