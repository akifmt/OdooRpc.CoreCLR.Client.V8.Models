using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DocumentsDocument
{
    public virtual string spreadsheet_binary_data { get; set; }
    public virtual string spreadsheet_data { get; set; }
    public virtual string thumbnail { get; set; }
    public virtual string spreadsheet_snapshot { get; set; }
    public virtual long[] spreadsheet_revision_ids { get; set; }
    public virtual string current_revision_uuid { get; set; }
    public virtual long[] activity_ids { get; set; }
    public virtual string activity_state { get; set; }
    public virtual object activity_user_id { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_type_icon { get; set; }
    public virtual string activity_date_deadline { get; set; }
    public virtual string my_activity_date_deadline { get; set; }
    public virtual string activity_summary { get; set; }
    public virtual string activity_exception_decoration { get; set; }
    public virtual string activity_exception_icon { get; set; }
    public virtual object activity_calendar_event_id { get; set; }
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
    public virtual string email_cc { get; set; }
    public virtual object attachment_id { get; set; }
    public virtual string attachment_name { get; set; }
    public virtual string attachment_type { get; set; }
    public virtual bool is_editable_attachment { get; set; }
    public virtual bool is_multipage { get; set; }
    public virtual string datas { get; set; }
    public virtual string raw { get; set; }
    public virtual string file_extension { get; set; }
    public virtual long file_size { get; set; }
    public virtual string checksum { get; set; }
    public virtual string mimetype { get; set; }
    public virtual string res_model { get; set; }
    public virtual string res_id { get; set; }
    public virtual string res_name { get; set; }
    public virtual string index_content { get; set; }
    public virtual string description { get; set; }
    public virtual long[] previous_attachment_ids { get; set; }
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual string thumbnail_status { get; set; }
    public virtual string url { get; set; }
    public virtual string url_preview_image { get; set; }
    public virtual string res_model_name { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual long[] favorited_ids { get; set; }
    public virtual bool is_favorited { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object owner_id { get; set; }
    public virtual long[] available_rule_ids { get; set; }
    public virtual object lock_uid { get; set; }
    public virtual bool is_locked { get; set; }
    public virtual object create_share_id { get; set; }
    public virtual object request_activity_id { get; set; }
    public virtual object folder_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] group_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object product_template_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual bool is_shared { get; set; }
    public virtual object project_id { get; set; }
    public virtual object task_id { get; set; }
    public virtual string handler { get; set; }
    public virtual bool has_embedded_pdf { get; set; }
}