using MicroEndpoints.Interfaces;
using Microsoft.AspNetCore.Builder;

namespace MicroEndpoints.Attributes;

/// <summary>
/// This is a custom attribute that inherits from the built-in Attribute class in .NET and implements 
/// the IHttpMethodAttribute interface. It defines a constructor that takes a single 
/// string parameter, which is used to set the value of the Template property.
/// 
/// The ConfigureEndpoint method is used to configure a web application’s endpoint with 
/// the specified template and request delegate. The app.MapGet method is called, 
/// passing in the Template string and the requestDelegate delegate. This allows the user 
/// to specify a template for a get request, which can be used to route requests to a specific 
/// handler method or controller action.
/// </summary>
public class GetAttribute : Attribute, IHttpMethodAttribute
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
    public GetAttribute(string template)
    {
        Template = template;
    }


    /// <summary>
    /// This method configures the endpoint for the given web 
    /// application and sets up the routing for the get request. 
    /// It takes two arguments: the web application (represented by the WebApplication class) 
    /// and a request delegate that defines the action to take when the request is received.
    /// </summary>
    /// <param name="app"></param>
    /// <param name="requestDelegate"></param>
    public void ConfigureEndpoint(WebApplication app, Delegate requestDelegate)
    {
        // This line of code uses the MapGet method defined
        // in the WebApplication class to register the template
        // specified in the Template property for a GET HTTP method.
        app.MapGet(Template, requestDelegate);
    }
}