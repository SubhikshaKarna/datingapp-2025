using System;
using Microsoft.AspNetCore.SignalR;

namespace API.Helpers;

public class CloudinarySettings
{
    public required string CloudName { get; set; }
    public required string ApiKey { get; set; }
    public required string ApiSecret {get; set; }
}
