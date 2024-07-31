using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DocumentsShare
{
    public virtual object alias_id { get; set; }
    public virtual string alias_name { get; set; }
    public virtual object alias_domain_id { get; set; }
    public virtual string alias_domain { get; set; }
    public virtual string alias_defaults { get; set; }
    public virtual string alias_email { get; set; }
    public virtual bool message_is_follower { get; set; }
    public virtual long[] message_follower_ids { get; set; }
    public virtual long[] message_partner_ids { get; set; }
    public virtual long[] message_ids { get; set; }
    public virtual bool has_message { get; set; }
    public virtual bool message_needaction { get; set; }
    public virtual long message_needaction_counter { get; set; }
    public virtual bool message_has_error { get; set; }
    public virtual long message_has_error_counter { get; set; }
    public virtual long message_attachment_count { get; set; }
    public virtual long[] rating_ids { get; set; }
    public virtual long[] website_message_ids { get; set; }
    public virtual bool message_has_sms_error { get; set; }
    public virtual object folder_id { get; set; }
    public virtual bool include_sub_folders { get; set; }
    public virtual string name { get; set; }
    public virtual string access_token { get; set; }
    public virtual string full_url { get; set; }
    public virtual long links_count { get; set; }
    public virtual string date_deadline { get; set; }
    public virtual string state { get; set; }
    public virtual bool can_upload { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual long[] document_ids { get; set; }
    public virtual string domain { get; set; }
    public virtual bool allow_upload { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object owner_id { get; set; }
    public virtual bool email_drop { get; set; }
    public virtual bool activity_option { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_summary { get; set; }
    public virtual long activity_date_deadline_range { get; set; }
    public virtual string activity_date_deadline_range_type { get; set; }
    public virtual string activity_note { get; set; }
    public virtual object activity_user_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] freezed_spreadsheet_ids { get; set; }
    public virtual string alias_full_name { get; set; }
    public virtual object alias_model_id { get; set; }
    public virtual long alias_force_thread_id { get; set; }
    public virtual object alias_parent_model_id { get; set; }
    public virtual long alias_parent_thread_id { get; set; }
    public virtual string alias_contact { get; set; }
    public virtual bool alias_incoming_local { get; set; }
    public virtual string alias_bounced_content { get; set; }
    public virtual string alias_status { get; set; }
}