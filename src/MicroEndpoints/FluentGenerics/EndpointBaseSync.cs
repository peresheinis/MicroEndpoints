using Microsoft.AspNetCore.Http;

namespace MicroEndpoints.FluentGenerics;

public static class EndpointBaseSync
{
    public static class WithQuery<T1>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract TResponse Handle(T1 parameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract void Handle(T1 parameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract IResult Handle(T1 parameter);
        }
    }

    public static class WithQuery<T1, T2>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract TResponse Handle(T1 firstParameter, T2 secondParameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract void Handle(T1 firstParameter, T2 secondParameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract IResult Handle(T1 firstParameter, T2 secondParameter);
        }
    }

    public static class WithQuery<T1, T2, T3>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract TResponse Handle(T1 firstParameter, T2 secondParameter, T3 thirdParameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract void Handle(T1 firstParameter, T2 secondParameter, T3 thirdParameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract IResult Handle(T1 firstParameter, T2 secondParameter, T3 thirdParameter);
        }
    }

    public static class WithQuery<T1, T2, T3, T4>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract TResponse Handle(T1 firstParameter, T2 secondParameter, T3 thirdParameter, T4 fourthParameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract void Handle(T1 firstParameter, T2 secondParameter, T3 thirdParameter, T4 fourthParameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract IResult Handle(T1 firstParameter, T2 secondParameter, T3 thirdParameter, T4 fourthParameter);
        }
    }

    public static class WithQuery<T1, T2, T3, T4, T5>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract TResponse Handle(T1 firstParameter, T2 secondParameter, T3 thirdParameter, T4 fourthParameter, T5 fifthParameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract void Handle(T1 firstParameter, T2 secondParameter, T3 thirdParameter, T4 fourthParameter, T5 fifthParameter);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract IResult Handle(T1 firstParameter, T2 secondParameter, T3 thirdParameter, T4 fourthParameter, T5 fifthParameter);
        }
    }

    /// <summary>
    /// Synchronous endpoint configuration with a request.
    /// </summary>
    public static class WithRequest<TRequest>
    {
        /// <summary>
        /// Synchronous endpoint configuration with a request and a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The response data.</returns>
            public abstract TResponse Handle(TRequest request);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request but without a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            /// <param name="request">The request data.</param>
            public abstract void Handle(TRequest request);
        }

        /// <summary>
        /// Synchronous endpoint configuration with a request and an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <param name="request">The request data.</param>
            /// <returns>The IResult response object.</returns>
            public abstract IResult Handle(TRequest request);
        }
    }

    /// <summary>
    /// Synchronous endpoint configuration without a request.
    /// </summary>
    public static class WithoutRequest
    {
        /// <summary>
        /// Synchronous endpoint configuration without a request but with a response.
        /// </summary>
        public abstract class WithResult<TResponse> : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns a response.
            /// </summary>
            /// <returns>The response data.</returns>
            public abstract TResponse Handle();
        }

        /// <summary>
        /// Synchronous endpoint configuration without a request or a response.
        /// </summary>
        public abstract class WithoutResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation.
            /// </summary>
            public abstract void Handle();
        }

        /// <summary>
        /// Synchronous endpoint configuration without a request but with an IResult response.
        /// </summary>
        public abstract class WithIResult : EndpointConfigurationSyncBase
        {
            /// <summary>
            /// Handles the operation and returns an IResult response.
            /// </summary>
            /// <returns>The IResult response object.</returns>
            public abstract IResult Handle();
        }
    }
}