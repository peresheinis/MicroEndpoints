using MicroEndpoints.Interfaces;
using Microsoft.AspNetCore.Builder;

namespace MicroEndpoints.Attributes;

/// <summary>
/// This is a custom attribute class that inherits from the System.Attribute 
/// class and implements the IHttpMethodMetadata interface. 
/// It has a private read-only string property named Template which holds the URL 
/// template for PATCH requests. The constructor for this class accepts a single string 
/// argument and assigns it to the Template property. Finally, the ConfigureEndpoint method maps 
/// the Template URL to a specific request handling method by using the app.MapPatch method defined
/// in the WebApplication class.
/// </summary>
public class PatchAttribute : Attribute, IHttpMethodAttribute
{
    /// <summary>
    /// The Template property is a public read-only string 
    /// that will be used as the template for the requested URL.
    /// </summary>
    public string Template { get; }

    /// <summary>
    /// This class inherits from the Attribute class and implements 
    /// the IHttpMethodAttribute interface, making it a valid attribute that 
    /// can be applied to methods or classes in C# code.
    /// </summary>
    /// <param name="template"></param>
    public PatchAttribute(string template)
    {
        Template = template;
    }

    /// <summary>
    /// This method configures the endpoint for the given web 
    /// application and sets up the routing for the patch request. 
    /// It takes two arguments: the web application (represented by the WebApplication class) 
    /// and a request delegate that defines the action to take when the request is received.
    /// </summary>
    /// <param name="app"></param>
    /// <param name="requestDelegate"></param>
    public void ConfigureEndpoint(WebApplication app, Delegate requestDelegate)
    {
        // This line of code uses the MapPatch method defined
        // in the WebApplication class to register the template
        // specified in the Template property for a PATCH HTTP method.
        app.MapPatch(Template, requestDelegate);
    }
}