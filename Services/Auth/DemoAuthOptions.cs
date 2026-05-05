using System.Collections.Generic;

namespace PharmacyExtra.Web.Services.Auth;

public sealed class DemoAuthOptions
{
    public List<DemoAuthUser> Users { get; set; } = new();
}

public sealed class DemoAuthUser
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public List<string> Roles { get; set; } = new();
}
