using Bunq.Sdk.Context;
using Bunq.Sdk.Http;
using Bunq.Sdk.Json;
using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Fetch the raw content of a tab attachment with given ID. The raw content is the binary representation of a file,
    /// without any JSON wrapping.
    /// </summary>
    public class AttachmentTabContent : BunqModel
    {
        /// <summary>
        /// Endpoint constants.
        /// </summary>
        protected const string ENDPOINT_URL_LISTING = "user/{0}/monetary-account/{1}/attachment-tab/{2}/content";
    
        /// <summary>
        /// Object type.
        /// </summary>
        private const string OBJECT_TYPE_GET = "AttachmentTabContent";
    
        /// <summary>
        /// Get the raw content of a specific attachment.
        /// </summary>
        public static BunqResponse<byte[]> List(int attachmentTabId, int? monetaryAccountId= null, IDictionary<string, string> customHeaders = null)
        {
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_LISTING, DetermineUserId(), DetermineMonetaryAccountId(monetaryAccountId), attachmentTabId), new Dictionary<string, string>(), customHeaders);
    
            return new BunqResponse<byte[]>(responseRaw.BodyBytes, responseRaw.Headers);
        }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static AttachmentTabContent CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<AttachmentTabContent>(json);
        }
    }
}
