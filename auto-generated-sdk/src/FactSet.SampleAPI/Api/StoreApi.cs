/* 
 * Swagger Petstore
 *
 * This is a sample server Petstore server.  You can find out more about     Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).      For this sample, you can use the api key `special-key` to test the authorization     filters.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using FactSet.SampleAPI.Client;
using FactSet.SampleAPI.Model;

namespace FactSet.SampleAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStoreApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with positive integer value.         Negative or non-integer values will generate API errors
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <returns></returns>
        void DeleteOrder (long orderId);

        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with positive integer value.         Negative or non-integer values will generate API errors
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOrderWithHttpInfo (long orderId);
        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>
        /// Returns a map of status codes to quantities
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, int&gt;</returns>
        Dictionary<string, int> GetInventory ();

        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>
        /// Returns a map of status codes to quantities
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, int&gt;</returns>
        ApiResponse<Dictionary<string, int>> GetInventoryWithHttpInfo ();
        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.         Other values will generated exceptions
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <returns>Order</returns>
        Order GetOrderById (long orderId);

        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.         Other values will generated exceptions
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <returns>ApiResponse of Order</returns>
        ApiResponse<Order> GetOrderByIdWithHttpInfo (long orderId);
        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <returns>Order</returns>
        Order PlaceOrder (Order body);

        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <returns>ApiResponse of Order</returns>
        ApiResponse<Order> PlaceOrderWithHttpInfo (Order body);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStoreApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with positive integer value.         Negative or non-integer values will generate API errors
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrderAsync (long orderId);

        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with positive integer value.         Negative or non-integer values will generate API errors
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOrderAsyncWithHttpInfo (long orderId);
        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>
        /// Returns a map of status codes to quantities
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Dictionary&lt;string, int&gt;</returns>
        System.Threading.Tasks.Task<Dictionary<string, int>> GetInventoryAsync ();

        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>
        /// Returns a map of status codes to quantities
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, int&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Dictionary<string, int>>> GetInventoryAsyncWithHttpInfo ();
        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.         Other values will generated exceptions
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <returns>Task of Order</returns>
        System.Threading.Tasks.Task<Order> GetOrderByIdAsync (long orderId);

        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.         Other values will generated exceptions
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        System.Threading.Tasks.Task<ApiResponse<Order>> GetOrderByIdAsyncWithHttpInfo (long orderId);
        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <returns>Task of Order</returns>
        System.Threading.Tasks.Task<Order> PlaceOrderAsync (Order body);

        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        System.Threading.Tasks.Task<ApiResponse<Order>> PlaceOrderAsyncWithHttpInfo (Order body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStoreApi : IStoreApiSync, IStoreApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StoreApi : IStoreApi
    {
        private FactSet.SampleAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreApi(String basePath)
        {
            this.Configuration = FactSet.SampleAPI.Client.Configuration.MergeConfigurations(
                FactSet.SampleAPI.Client.GlobalConfiguration.Instance,
                new FactSet.SampleAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new FactSet.SampleAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FactSet.SampleAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = FactSet.SampleAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StoreApi(FactSet.SampleAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = FactSet.SampleAPI.Client.Configuration.MergeConfigurations(
                FactSet.SampleAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new FactSet.SampleAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new FactSet.SampleAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = FactSet.SampleAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StoreApi(FactSet.SampleAPI.Client.ISynchronousClient client,FactSet.SampleAPI.Client.IAsynchronousClient asyncClient, FactSet.SampleAPI.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = FactSet.SampleAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public FactSet.SampleAPI.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public FactSet.SampleAPI.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FactSet.SampleAPI.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FactSet.SampleAPI.Client.ExceptionFactory ExceptionFactory
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
        /// Delete purchase order by ID For valid response try integer IDs with positive integer value.         Negative or non-integer values will generate API errors
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <returns></returns>
        public void DeleteOrder (long orderId)
        {
             DeleteOrderWithHttpInfo(orderId);
        }

        /// <summary>
        /// Delete purchase order by ID For valid response try integer IDs with positive integer value.         Negative or non-integer values will generate API errors
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public FactSet.SampleAPI.Client.ApiResponse<Object> DeleteOrderWithHttpInfo (long orderId)
        {
            FactSet.SampleAPI.Client.RequestOptions localVarRequestOptions = new FactSet.SampleAPI.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = FactSet.SampleAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FactSet.SampleAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("orderId", FactSet.SampleAPI.Client.ClientUtils.ParameterToString(orderId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/store/order/{orderId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOrder", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete purchase order by ID For valid response try integer IDs with positive integer value.         Negative or non-integer values will generate API errors
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrderAsync (long orderId)
        {
             await DeleteOrderAsyncWithHttpInfo(orderId);

        }

        /// <summary>
        /// Delete purchase order by ID For valid response try integer IDs with positive integer value.         Negative or non-integer values will generate API errors
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<FactSet.SampleAPI.Client.ApiResponse<Object>> DeleteOrderAsyncWithHttpInfo (long orderId)
        {

            FactSet.SampleAPI.Client.RequestOptions localVarRequestOptions = new FactSet.SampleAPI.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("orderId", FactSet.SampleAPI.Client.ClientUtils.ParameterToString(orderId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/store/order/{orderId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOrder", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns pet inventories by status Returns a map of status codes to quantities
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Dictionary&lt;string, int&gt;</returns>
        public Dictionary<string, int> GetInventory ()
        {
             FactSet.SampleAPI.Client.ApiResponse<Dictionary<string, int>> localVarResponse = GetInventoryWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns pet inventories by status Returns a map of status codes to quantities
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Dictionary&lt;string, int&gt;</returns>
        public FactSet.SampleAPI.Client.ApiResponse< Dictionary<string, int> > GetInventoryWithHttpInfo ()
        {
            FactSet.SampleAPI.Client.RequestOptions localVarRequestOptions = new FactSet.SampleAPI.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = FactSet.SampleAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FactSet.SampleAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarRequestOptions.HeaderParameters.Add("api_key", this.Configuration.GetApiKeyWithPrefix("api_key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< Dictionary<string, int> >("/store/inventory", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInventory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns pet inventories by status Returns a map of status codes to quantities
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Dictionary&lt;string, int&gt;</returns>
        public async System.Threading.Tasks.Task<Dictionary<string, int>> GetInventoryAsync ()
        {
             FactSet.SampleAPI.Client.ApiResponse<Dictionary<string, int>> localVarResponse = await GetInventoryAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns pet inventories by status Returns a map of status codes to quantities
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Dictionary&lt;string, int&gt;)</returns>
        public async System.Threading.Tasks.Task<FactSet.SampleAPI.Client.ApiResponse<Dictionary<string, int>>> GetInventoryAsyncWithHttpInfo ()
        {

            FactSet.SampleAPI.Client.RequestOptions localVarRequestOptions = new FactSet.SampleAPI.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarRequestOptions.HeaderParameters.Add("api_key", this.Configuration.GetApiKeyWithPrefix("api_key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Dictionary<string, int>>("/store/inventory", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetInventory", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Find purchase order by ID For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.         Other values will generated exceptions
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <returns>Order</returns>
        public Order GetOrderById (long orderId)
        {
             FactSet.SampleAPI.Client.ApiResponse<Order> localVarResponse = GetOrderByIdWithHttpInfo(orderId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find purchase order by ID For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.         Other values will generated exceptions
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <returns>ApiResponse of Order</returns>
        public FactSet.SampleAPI.Client.ApiResponse< Order > GetOrderByIdWithHttpInfo (long orderId)
        {
            FactSet.SampleAPI.Client.RequestOptions localVarRequestOptions = new FactSet.SampleAPI.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/xml",
                "application/json"
            };

            var localVarContentType = FactSet.SampleAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FactSet.SampleAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("orderId", FactSet.SampleAPI.Client.ClientUtils.ParameterToString(orderId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get< Order >("/store/order/{orderId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOrderById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Find purchase order by ID For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.         Other values will generated exceptions
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <returns>Task of Order</returns>
        public async System.Threading.Tasks.Task<Order> GetOrderByIdAsync (long orderId)
        {
             FactSet.SampleAPI.Client.ApiResponse<Order> localVarResponse = await GetOrderByIdAsyncWithHttpInfo(orderId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Find purchase order by ID For valid response try integer IDs with value &gt;&#x3D; 1 and &lt;&#x3D; 10.         Other values will generated exceptions
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        public async System.Threading.Tasks.Task<FactSet.SampleAPI.Client.ApiResponse<Order>> GetOrderByIdAsyncWithHttpInfo (long orderId)
        {

            FactSet.SampleAPI.Client.RequestOptions localVarRequestOptions = new FactSet.SampleAPI.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/xml",
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.PathParameters.Add("orderId", FactSet.SampleAPI.Client.ClientUtils.ParameterToString(orderId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Order>("/store/order/{orderId}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOrderById", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Place an order for a pet 
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <returns>Order</returns>
        public Order PlaceOrder (Order body)
        {
             FactSet.SampleAPI.Client.ApiResponse<Order> localVarResponse = PlaceOrderWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Place an order for a pet 
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <returns>ApiResponse of Order</returns>
        public FactSet.SampleAPI.Client.ApiResponse< Order > PlaceOrderWithHttpInfo (Order body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new FactSet.SampleAPI.Client.ApiException(400, "Missing required parameter 'body' when calling StoreApi->PlaceOrder");

            FactSet.SampleAPI.Client.RequestOptions localVarRequestOptions = new FactSet.SampleAPI.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/xml",
                "application/json"
            };

            var localVarContentType = FactSet.SampleAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = FactSet.SampleAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;


            // make the HTTP request
            var localVarResponse = this.Client.Post< Order >("/store/order", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PlaceOrder", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Place an order for a pet 
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <returns>Task of Order</returns>
        public async System.Threading.Tasks.Task<Order> PlaceOrderAsync (Order body)
        {
             FactSet.SampleAPI.Client.ApiResponse<Order> localVarResponse = await PlaceOrderAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Place an order for a pet 
        /// </summary>
        /// <exception cref="FactSet.SampleAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">order placed for purchasing the pet</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        public async System.Threading.Tasks.Task<FactSet.SampleAPI.Client.ApiResponse<Order>> PlaceOrderAsyncWithHttpInfo (Order body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new FactSet.SampleAPI.Client.ApiException(400, "Missing required parameter 'body' when calling StoreApi->PlaceOrder");


            FactSet.SampleAPI.Client.RequestOptions localVarRequestOptions = new FactSet.SampleAPI.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/xml",
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = body;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Order>("/store/order", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PlaceOrder", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
