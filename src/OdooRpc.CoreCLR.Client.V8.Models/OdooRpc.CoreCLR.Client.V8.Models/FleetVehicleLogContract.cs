namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class FleetVehicleLogContract
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
    public virtual object vehicle_id { get; set; }
    public virtual object cost_subtype_id { get; set; }
    public virtual string amount { get; set; }
    public virtual string date { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual object user_id { get; set; }
    public virtual string start_date { get; set; }
    public virtual string expiration_date { get; set; }
    public virtual long days_left { get; set; }
    public virtual bool expires_today { get; set; }
    public virtual object insurer_id { get; set; }
    public virtual object purchaser_id { get; set; }
    public virtual string ins_ref { get; set; }
    public virtual string state { get; set; }
    public virtual string notes { get; set; }
    public virtual string cost_generated { get; set; }
    public virtual string cost_frequency { get; set; }
    public virtual long[] service_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object purchaser_employee_id { get; set; }
}