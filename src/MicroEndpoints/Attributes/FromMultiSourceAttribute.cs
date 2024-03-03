using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MicroEndpoints.Attributes;

/// <summary>
/// This is a custom attribute class that inherits from the .NET Attribute class.
/// It also implements the IBindingSourceMetadata interface, which allows it to be used to 
/// specify metadata for a binding source.
/// 
/// It has a single property named BindingSource, which is a read-only property 
/// that returns an object that represents the binding source to be used.
/// The BindingSource property is initialized with the result of calling the CompositeBindingSource.Create method, 
/// which creates a composite binding source by combining two other binding sources - 
/// BindingSource.Path and BindingSource.Query.The nameof(FromMultiSourceAttribute)) argument specifies 
/// the name of the attribute that is used to identify this binding source in configuration files.
/// </summary>
public sealed class FromMultiSourceAttribute : Attribute, IBindingSourceMetadata
{
    public BindingSource BindingSource { get; } = CompositeBindingSource.Create(
    new[] { BindingSource.Path, BindingSource.Query },
    nameof(FromMultiSourceAttribute));
}

