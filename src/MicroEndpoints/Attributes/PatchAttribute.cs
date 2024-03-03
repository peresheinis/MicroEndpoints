using MicroEndpoints.Interfaces;
using Microsoft.AspNetCore.Builder;

namespace MicroEndpoints.Attributes;

public class PatchAttribute : Attribute, IHttpMethodAttribute
{
    public string Template { get; }

    public PatchAttribute(string template)
    {
        Template = template;
    }

    public void ConfigureEndpoint(WebApplication app, Delegate requestDelegate)
    {
        app.MapPatch(Template, requestDelegate);
    }
}