using Microsoft.AspNetCore.Builder;

namespace MicroEndpoints.Interfaces;

/// <summary>
/// This is an interface that defines two methods: getting a template string a
/// nd configuring the endpoint of a web application using a passed-in delegate. 
/// This interface is designed for implementing HTTP method attributes and can be used for 
/// flexible and modular configuration of web applications.
/// 
/// The Template method allows defining a URL pattern that will be used for this method,
/// and the ConfigureEndpoint method accepts a delegate (usually a function or method)
/// and configures it as a request handler for a specific application endpoint.
/// This allows developers to easily add new HTTP methods without the need for complex and repetitive configuration code.
/// </summary>
internal interface IHttpMethodAttribute
{
    string Template { get; }
    void ConfigureEndpoint(WebApplication app, Delegate requestDelegate);
}