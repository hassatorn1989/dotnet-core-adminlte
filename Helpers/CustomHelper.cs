using System;

namespace PjAdminlte.Helpers;

public static class CustomHelper
{
    public static string GetRandomString()
    {
        return Guid.NewGuid().ToString();
    }
}
