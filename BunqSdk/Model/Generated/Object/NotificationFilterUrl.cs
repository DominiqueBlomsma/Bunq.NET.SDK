using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Object
{
    /// <summary>
    /// </summary>
    public class NotificationFilterUrl : BunqModel
    {
        /// <summary>
        /// The notification category that will match this notification filter.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
    
        /// <summary>
        /// The URL to which the callback should be made.
        /// </summary>
        [JsonProperty(PropertyName = "notification_target")]
        public string NotificationTarget { get; set; }
    
        /// <summary>
        /// The id of the NotificationFilterUrl.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }
    
        /// <summary>
        /// The timestamp of the NotificationFilterUrl's creation.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }
    
        /// <summary>
        /// The timestamp of the NotificationFilterUrl's last update.
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }
    
    
        public NotificationFilterUrl(string category, string notificationTarget)
        {
            Category = category;
            NotificationTarget = notificationTarget;
        }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.Id != null)
            {
                return false;
            }
    
            if (this.Created != null)
            {
                return false;
            }
    
            if (this.Updated != null)
            {
                return false;
            }
    
            if (this.Category != null)
            {
                return false;
            }
    
            if (this.NotificationTarget != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static NotificationFilterUrl CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<NotificationFilterUrl>(json);
        }
    }
}
