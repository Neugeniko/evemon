/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.5.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStatusApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve the uptime and player counts
        /// </summary>
        /// <remarks>
        /// EVE Server status  - --  This route is cached for up to 30 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>GetStatusOk</returns>
        GetStatusOk GetStatus (string datasource = null, string userAgent = null, string xUserAgent = null);

        /// <summary>
        /// Retrieve the uptime and player counts
        /// </summary>
        /// <remarks>
        /// EVE Server status  - --  This route is cached for up to 30 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>ApiResponse of GetStatusOk</returns>
        ApiResponse<GetStatusOk> GetStatusWithHttpInfo (string datasource = null, string userAgent = null, string xUserAgent = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve the uptime and player counts
        /// </summary>
        /// <remarks>
        /// EVE Server status  - --  This route is cached for up to 30 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of GetStatusOk</returns>
        System.Threading.Tasks.Task<GetStatusOk> GetStatusAsync (string datasource = null, string userAgent = null, string xUserAgent = null);

        /// <summary>
        /// Retrieve the uptime and player counts
        /// </summary>
        /// <remarks>
        /// EVE Server status  - --  This route is cached for up to 30 seconds
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of ApiResponse (GetStatusOk)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetStatusOk>> GetStatusAsyncWithHttpInfo (string datasource = null, string userAgent = null, string xUserAgent = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StatusApi : IStatusApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StatusApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StatusApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieve the uptime and player counts EVE Server status  - --  This route is cached for up to 30 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>GetStatusOk</returns>
        public GetStatusOk GetStatus (string datasource = null, string userAgent = null, string xUserAgent = null)
        {
             ApiResponse<GetStatusOk> localVarResponse = GetStatusWithHttpInfo(datasource, userAgent, xUserAgent);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the uptime and player counts EVE Server status  - --  This route is cached for up to 30 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>ApiResponse of GetStatusOk</returns>
        public ApiResponse< GetStatusOk > GetStatusWithHttpInfo (string datasource = null, string userAgent = null, string xUserAgent = null)
        {

            var localVarPath = "/v1/status/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "datasource", datasource)); // query parameter
            if (userAgent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user_agent", userAgent)); // query parameter
            if (xUserAgent != null) localVarHeaderParams.Add("X-User-Agent", Configuration.ApiClient.ParameterToString(xUserAgent)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetStatusOk>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetStatusOk) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetStatusOk)));
        }

        /// <summary>
        /// Retrieve the uptime and player counts EVE Server status  - --  This route is cached for up to 30 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of GetStatusOk</returns>
        public async System.Threading.Tasks.Task<GetStatusOk> GetStatusAsync (string datasource = null, string userAgent = null, string xUserAgent = null)
        {
             ApiResponse<GetStatusOk> localVarResponse = await GetStatusAsyncWithHttpInfo(datasource, userAgent, xUserAgent);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the uptime and player counts EVE Server status  - --  This route is cached for up to 30 seconds
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="datasource">The server name you would like data from (optional, default to tranquility)</param>
        /// <param name="userAgent">Client identifier, takes precedence over headers (optional)</param>
        /// <param name="xUserAgent">Client identifier, takes precedence over User-Agent (optional)</param>
        /// <returns>Task of ApiResponse (GetStatusOk)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetStatusOk>> GetStatusAsyncWithHttpInfo (string datasource = null, string userAgent = null, string xUserAgent = null)
        {

            var localVarPath = "/v1/status/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (datasource != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "datasource", datasource)); // query parameter
            if (userAgent != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "user_agent", userAgent)); // query parameter
            if (xUserAgent != null) localVarHeaderParams.Add("X-User-Agent", Configuration.ApiClient.ParameterToString(xUserAgent)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetStatusOk>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetStatusOk) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetStatusOk)));
        }

    }
}