using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpBom
{
    public virtual string analytic_distribution { get; set; }
    public virtual long analytic_precision { get; set; }
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
    public virtual string code { get; set; }
    public virtual bool active { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual object product_tmpl_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual long[] bom_line_ids { get; set; }
    public virtual long[] byproduct_ids { get; set; }
    public virtual double product_qty { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual long[] operation_ids { get; set; }
    public virtual string ready_to_produce { get; set; }
    public virtual object picking_type_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string consumption { get; set; }
    public virtual long[] possible_product_template_attribute_value_ids { get; set; }
    public virtual bool allow_operation_dependencies { get; set; }
    public virtual long produce_delay { get; set; }
    public virtual long days_to_prepare_mo { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string analytic_distribution_text { get; set; }
    public virtual long[] analytic_account_ids { get; set; }
    public virtual long version { get; set; }
    public virtual object previous_bom_id { get; set; }
    public virtual string image_128 { get; set; }
    public virtual long[] eco_ids { get; set; }
    public virtual long eco_count { get; set; }
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
}