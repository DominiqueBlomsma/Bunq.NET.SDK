using Bunq.Sdk.Model.Core;
using Bunq.Sdk.Model.Generated.Object;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Endpoint for managing monetary accounts which are connected to external services.
    /// </summary>
    public class MonetaryAccountExternal : BunqModel
    {
        /// <summary>
        /// Field constants.
        /// </summary>
        public const string FIELD_CURRENCY = "currency";
        public const string FIELD_DESCRIPTION = "description";
        public const string FIELD_DAILY_LIMIT = "daily_limit";
        public const string FIELD_AVATAR_UUID = "avatar_uuid";
        public const string FIELD_STATUS = "status";
        public const string FIELD_SUB_STATUS = "sub_status";
        public const string FIELD_REASON = "reason";
        public const string FIELD_REASON_DESCRIPTION = "reason_description";
        public const string FIELD_DISPLAY_NAME = "display_name";
        public const string FIELD_SETTING = "setting";
    
    
        /// <summary>
        /// The currency of the MonetaryAccountExternal as an ISO 4217 formatted currency code.
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }
    
        /// <summary>
        /// The description of the MonetaryAccountExternal. Defaults to 'bunq account'.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    
        /// <summary>
        /// The daily spending limit Amount of the MonetaryAccountExternal. Defaults to 1000 EUR. Currency must match
        /// the MonetaryAccountExternal's currency. Limited to 10000 EUR.
        /// </summary>
        [JsonProperty(PropertyName = "daily_limit")]
        public Amount DailyLimit { get; set; }
    
        /// <summary>
        /// The UUID of the Avatar of the MonetaryAccountExternal.
        /// </summary>
        [JsonProperty(PropertyName = "avatar_uuid")]
        public string AvatarUuid { get; set; }
    
        /// <summary>
        /// The status of the MonetaryAccountExternal. Can be: ACTIVE, BLOCKED, CANCELLED or PENDING_REOPEN
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    
        /// <summary>
        /// The sub-status of the MonetaryAccountExternal providing extra information regarding the status. Will be NONE
        /// for ACTIVE or PENDING_REOPEN, COMPLETELY or ONLY_ACCEPTING_INCOMING for BLOCKED and REDEMPTION_INVOLUNTARY,
        /// REDEMPTION_VOLUNTARY or PERMANENT for CANCELLED.
        /// </summary>
        [JsonProperty(PropertyName = "sub_status")]
        public string SubStatus { get; set; }
    
        /// <summary>
        /// The reason for voluntarily cancelling (closing) the MonetaryAccountExternal, can only be OTHER.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }
    
        /// <summary>
        /// The optional free-form reason for voluntarily cancelling (closing) the MonetaryAccountExternal. Can be any
        /// user provided message.
        /// </summary>
        [JsonProperty(PropertyName = "reason_description")]
        public string ReasonDescription { get; set; }
    
        /// <summary>
        /// The legal name of the user / company using this monetary account.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// The settings of the MonetaryAccountExternal.
        /// </summary>
        [JsonProperty(PropertyName = "setting")]
        public MonetaryAccountSetting Setting { get; set; }
    
        /// <summary>
        /// The id of the MonetaryAccountExternal.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }
    
        /// <summary>
        /// The timestamp of the MonetaryAccountExternal's creation.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public string Created { get; set; }
    
        /// <summary>
        /// The timestamp of the MonetaryAccountExternal's last update.
        /// </summary>
        [JsonProperty(PropertyName = "updated")]
        public string Updated { get; set; }
    
        /// <summary>
        /// The Avatar of the MonetaryAccountExternal.
        /// </summary>
        [JsonProperty(PropertyName = "avatar")]
        public Avatar Avatar { get; set; }
    
        /// <summary>
        /// The maximum Amount the MonetaryAccountExternal can be 'in the red'.
        /// </summary>
        [JsonProperty(PropertyName = "overdraft_limit")]
        public Amount OverdraftLimit { get; set; }
    
        /// <summary>
        /// The current available balance Amount of the MonetaryAccountExternal.
        /// </summary>
        [JsonProperty(PropertyName = "balance")]
        public Amount Balance { get; set; }
    
        /// <summary>
        /// The Aliases for the MonetaryAccountExternal.
        /// </summary>
        [JsonProperty(PropertyName = "alias")]
        public List<Pointer> Alias { get; set; }
    
        /// <summary>
        /// The MonetaryAccountExternal's public UUID.
        /// </summary>
        [JsonProperty(PropertyName = "public_uuid")]
        public string PublicUuid { get; set; }
    
        /// <summary>
        /// The id of the User who owns the MonetaryAccountExternal.
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public int? UserId { get; set; }
    
        /// <summary>
        /// The profile of the account.
        /// </summary>
        [JsonProperty(PropertyName = "monetary_account_profile")]
        public MonetaryAccountProfile MonetaryAccountProfile { get; set; }
    
        /// <summary>
        /// The ids of the AutoSave.
        /// </summary>
        [JsonProperty(PropertyName = "all_auto_save_id")]
        public List<BunqId> AllAutoSaveId { get; set; }
    
    
    
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
    
            if (this.Avatar != null)
            {
                return false;
            }
    
            if (this.Currency != null)
            {
                return false;
            }
    
            if (this.Description != null)
            {
                return false;
            }
    
            if (this.DailyLimit != null)
            {
                return false;
            }
    
            if (this.OverdraftLimit != null)
            {
                return false;
            }
    
            if (this.Balance != null)
            {
                return false;
            }
    
            if (this.Alias != null)
            {
                return false;
            }
    
            if (this.PublicUuid != null)
            {
                return false;
            }
    
            if (this.Status != null)
            {
                return false;
            }
    
            if (this.SubStatus != null)
            {
                return false;
            }
    
            if (this.Reason != null)
            {
                return false;
            }
    
            if (this.ReasonDescription != null)
            {
                return false;
            }
    
            if (this.UserId != null)
            {
                return false;
            }
    
            if (this.MonetaryAccountProfile != null)
            {
                return false;
            }
    
            if (this.DisplayName != null)
            {
                return false;
            }
    
            if (this.Setting != null)
            {
                return false;
            }
    
            if (this.AllAutoSaveId != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static MonetaryAccountExternal CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<MonetaryAccountExternal>(json);
        }
    }
}