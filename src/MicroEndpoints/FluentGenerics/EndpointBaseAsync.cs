using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroEndpoints.FluentGenerics;

public static class EndpointBaseAsync
{
    public static class WithQuery<T1>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract Task<TResponse> HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract Task HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract Task<IResult> HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter, CancellationToken cancellationToken = default);
        }
    }

    public static class WithQuery<T1, T2>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract Task<TResponse> HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract Task HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract Task<IResult> HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter, CancellationToken cancellationToken = default);
        }
    }

    public static class WithQuery<T1, T2, T3>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract Task<TResponse> HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter,
                T3 thirdParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract void HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter,
                T3 thirdParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract Task<IResult> HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter,
                T3 thirdParameter, CancellationToken cancellationToken = default);
        }
    }

    public static class WithQuery<T1, T2, T3, T4>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract Task<TResponse> HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter,
                T3 thirdParameter,
                T4 fourthParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract void HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter,
                T3 thirdParameter,
                T4 fourthParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract Task<IResult> HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter,
                T3 thirdParameter,
                T4 fourthParameter, CancellationToken cancellationToken = default);
        }
    }

    public static class WithQuery<T1, T2, T3, T4, T5>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract Task<TResponse> HandleAsync(
                [FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter,
                T3 thirdParameter,
                T4 fourthParameter,
                T5 fifthParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract void HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter,
                T3 thirdParameter,
                T4 fourthParameter,
                T5 fifthParameter, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract Task<IResult> HandleAsync([FromServices] IServiceProvider serviceProvider,
                T1 firstParameter,
                T2 secondParameter,
                T3 thirdParameter,
                T4 fourthParameter,
                T5 fifthParameter, CancellationToken cancellationToken = default);
        }
    }

    public static class WithRequest<TRequest>
    {
        /// <summary>
        /// Asynchronous endpoint configuration with a specified request and response type.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Asynchronously handles the incoming request and returns a response.
            /// </summary>
            /// <param name="serviceProvider">The service provider for dependency resolution.</param>
            /// <param name="request">The incoming request object.</param>
            /// <param name="cancellationToken">A token that can be used to cancel the operation.</param>
            /// <returns>A task that represents the asynchronous operation. The task result contains the response object.</returns>
            public abstract Task<TResponse> HandleAsync([FromServices] IServiceProvider serviceProvider,
                TRequest request, 
                CancellationToken cancellationToken = default);
        }
        /// <summary>
        /// Asynchronous endpoint configuration with a specified request type but no response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Asynchronously handles the incoming request.
            /// </summary>
            /// <param name="serviceProvider">The service provider for dependency resolution.</param>
            /// <param name="request">The incoming request object.</param>
            /// <param name="cancellationToken">A token that can be used to cancel the operation.</param>
            /// <returns>A task that represents the asynchronous operation.</returns>
            public abstract Task HandleAsync(
                [FromServices] IServiceProvider serviceProvider,
                TRequest request, CancellationToken cancellationToken = default);
        }

        /// <summary>
        /// Asynchronous endpoint configuration with a specified request type and IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Asynchronously handles the incoming request and returns an IResult response.
            /// </summary>
            /// <param name="serviceProvider">The service provider for dependency resolution.</param>
            /// <param name="request">The incoming request object.</param>
            /// <param name="cancellationToken">A token that can be used to cancel the operation.</param>
            /// <returns>A task that represents the asynchronous operation. The task result contains the IResult response object.</returns>
            public abstract Task<IResult> HandleAsync(
                [FromServices] IServiceProvider serviceProvider,
                TRequest request, CancellationToken cancellationToken = default);
        }
        /// <summary>
        /// Asynchronous endpoint configuration with a specified request type and async enumerable response.
        /// </summary>
        public abstract class WithAsyncEnumerableResult<T> : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Asynchronously handles the incoming request and returns an async enumerable response.
            /// </summary>
            /// <param name="serviceProvider">The service provider for dependency resolution.</param>
            /// <param name="request">The incoming request object.</param>
            /// <param name="cancellationToken">A token that can be used to cancel the operation.</param>
            /// <returns>An async enumerable that contains the response objects.</returns>
            public abstract IAsyncEnumerable<T> HandleAsync(
                [FromServices] IServiceProvider serviceProvider,
                TRequest request, CancellationToken cancellationToken = default);
        }
    }

    public static class WithoutRequest
    {
        /// <summary>
        /// Asynchronous endpoint configuration with a specified response type but no request.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Asynchronously handles the operation and returns a response.
            /// </summary>
            /// <param name="serviceProvider">The service provider for dependency resolution.</param>
            /// <param name="cancellationToken">A token that can be used to cancel the operation.</param>
            /// <returns>A task that represents the asynchronous operation. The task result contains the response object.</returns>
            public abstract Task<TResponse> HandleAsync(
                [FromServices] IServiceProvider serviceProvider,
                CancellationToken cancellationToken = default
      );
        }

        /// <summary>
        /// Asynchronous endpoint configuration with no request or response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Asynchronously handles the operation.
            /// </summary>
            /// <param name="serviceProvider">The service provider for dependency resolution.</param>
            /// <param name="cancellationToken">A token that can be used to cancel the operation.</param>
            /// <returns>A task that represents the asynchronous operation.</returns>
            public abstract Task HandleAsync(
                [FromServices] IServiceProvider serviceProvider,
                CancellationToken cancellationToken = default
      );
        }

        /// <summary>
        /// Asynchronous endpoint configuration without a request but with an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Asynchronously handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="serviceProvider">The service provider for dependency resolution.</param>
            /// <param name="cancellationToken">A token that can be used to cancel the operation.</param>
            /// <returns>A task that represents the asynchronous operation. The task result contains the IResult response object.</returns>
            public abstract Task<IResult> HandleAsync(
                [FromServices] IServiceProvider serviceProvider,
                CancellationToken cancellationToken = default
      );
        }

        /// <summary>
        /// Asynchronous endpoint configuration without a request but with an async enumerable response.
        /// </summary>
        public abstract class WithAsyncEnumerableResult<T> : EndpointConfigurationAsyncBase
        {
            /// <summary>
            /// Asynchronously handles the operation and returns an async enumerable response.
            /// </summary>
            /// <param name="serviceProvider">The service provider for dependency resolution.</param>
            /// <param name="cancellationToken">A token that can be used to cancel the operation.</param>
            /// <returns>An async enumerable that contains the response objects.</returns>
            public abstract IAsyncEnumerable<T> HandleAsync(
                [FromServices] IServiceProvider serviceProvider,
                CancellationToken cancellationToken = default
      );
        }
    }
}
