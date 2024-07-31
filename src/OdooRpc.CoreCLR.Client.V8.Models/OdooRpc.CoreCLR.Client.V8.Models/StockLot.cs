using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockLot
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
    public virtual string name { get; set; }

    [JsonPropertyName("ref")]
    public virtual string ref_ { get; set; }

    public virtual object product_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual long[] quant_ids { get; set; }
    public virtual double product_qty { get; set; }
    public virtual string note { get; set; }
    public virtual bool display_complete { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] delivery_ids { get; set; }
    public virtual long delivery_count { get; set; }
    public virtual object last_delivery_partner_id { get; set; }
    public virtual object[] lot_properties { get; set; }
    public virtual object location_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] sale_order_ids { get; set; }
    public virtual long sale_order_count { get; set; }
}