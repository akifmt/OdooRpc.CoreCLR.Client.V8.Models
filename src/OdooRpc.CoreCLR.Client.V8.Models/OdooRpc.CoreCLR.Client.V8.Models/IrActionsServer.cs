using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrActionsServer
{
    public virtual string name { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual string xml_id { get; set; }
    public virtual string path { get; set; }
    public virtual string help { get; set; }
    public virtual object binding_model_id { get; set; }
    public virtual string binding_type { get; set; }
    public virtual string binding_view_types { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string usage { get; set; }
    public virtual string state { get; set; }
    public virtual long sequence { get; set; }
    public virtual object model_id { get; set; }
    public virtual long[] available_model_ids { get; set; }
    public virtual string model_name { get; set; }
    public virtual string code { get; set; }
    public virtual long[] child_ids { get; set; }
    public virtual object crud_model_id { get; set; }
    public virtual string crud_model_name { get; set; }
    public virtual object link_field_id { get; set; }
    public virtual long[] groups_id { get; set; }
    public virtual object update_field_id { get; set; }
    public virtual string update_path { get; set; }
    public virtual object update_related_model_id { get; set; }
    public virtual string update_field_type { get; set; }
    public virtual string update_m2m_operation { get; set; }
    public virtual string update_boolean_value { get; set; }
    public virtual string value { get; set; }
    public virtual string evaluation_type { get; set; }
    public virtual string resource_ref { get; set; }
    public virtual object selection_value { get; set; }
    public virtual string value_field_to_show { get; set; }
    public virtual string webhook_url { get; set; }
    public virtual long[] webhook_field_ids { get; set; }
    public virtual string webhook_sample_payload { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual object template_id { get; set; }
    public virtual bool mail_post_autofollow { get; set; }
    public virtual string mail_post_method { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_summary { get; set; }
    public virtual string activity_note { get; set; }
    public virtual long activity_date_deadline_range { get; set; }
    public virtual string activity_date_deadline_range_type { get; set; }
    public virtual string activity_user_type { get; set; }
    public virtual object activity_user_id { get; set; }
    public virtual string activity_user_field_name { get; set; }
    public virtual object sms_template_id { get; set; }
    public virtual string sms_method { get; set; }
    public virtual string website_path { get; set; }
    public virtual string website_url { get; set; }
    public virtual bool website_published { get; set; }
}