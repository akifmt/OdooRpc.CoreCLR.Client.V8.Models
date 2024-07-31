using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpEco
{
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
    public virtual string name { get; set; }
    public virtual object user_id { get; set; }
    public virtual object type_id { get; set; }
    public virtual object stage_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual string priority { get; set; }
    public virtual string note { get; set; }
    public virtual string effectivity { get; set; }
    public virtual string effectivity_date { get; set; }
    public virtual long[] approval_ids { get; set; }
    public virtual string state { get; set; }
    public virtual bool user_can_approve { get; set; }
    public virtual bool user_can_reject { get; set; }
    public virtual string kanban_state { get; set; }
    public virtual string legend_blocked { get; set; }
    public virtual string legend_done { get; set; }
    public virtual string legend_normal { get; set; }
    public virtual string kanban_state_label { get; set; }
    public virtual bool allow_change_kanban_state { get; set; }
    public virtual bool allow_change_stage { get; set; }
    public virtual bool allow_apply_change { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object production_id { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual object bom_id { get; set; }
    public virtual object new_bom_id { get; set; }
    public virtual long new_bom_revision { get; set; }
    public virtual long[] bom_change_ids { get; set; }
    public virtual long[] bom_rebase_ids { get; set; }
    public virtual long[] routing_change_ids { get; set; }
    public virtual long mrp_document_count { get; set; }
    public virtual long[] mrp_document_ids { get; set; }
    public virtual object displayed_image_id { get; set; }
    public virtual object displayed_image_attachment_id { get; set; }
    public virtual long color { get; set; }
    public virtual bool active { get; set; }
    public virtual object current_bom_id { get; set; }
    public virtual long[] previous_change_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}