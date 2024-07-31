namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class EventRegistration
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
    public virtual object event_id { get; set; }
    public virtual object event_ticket_id { get; set; }
    public virtual bool active { get; set; }
    public virtual string barcode { get; set; }
    public virtual object utm_campaign_id { get; set; }
    public virtual object utm_source_id { get; set; }
    public virtual object utm_medium_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string name { get; set; }
    public virtual string email { get; set; }
    public virtual string phone { get; set; }
    public virtual string company_name { get; set; }
    public virtual string date_closed { get; set; }
    public virtual string event_begin_date { get; set; }
    public virtual string event_end_date { get; set; }
    public virtual object event_organizer_id { get; set; }
    public virtual object event_user_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string state { get; set; }
    public virtual object[] registration_properties { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object visitor_id { get; set; }
    public virtual long[] registration_answer_ids { get; set; }
    public virtual long[] registration_answer_choice_ids { get; set; }
}