namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountOnlineLink
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
    public virtual long[] account_online_account_ids { get; set; }
    public virtual string last_refresh { get; set; }
    public virtual string next_refresh { get; set; }
    public virtual string state { get; set; }
    public virtual string connection_state_details { get; set; }
    public virtual bool auto_sync { get; set; }
    public virtual object company_id { get; set; }
    public virtual bool has_unlinked_accounts { get; set; }
    public virtual string name { get; set; }
    public virtual string client_id { get; set; }
    public virtual string refresh_token { get; set; }
    public virtual string access_token { get; set; }
    public virtual string provider_data { get; set; }
    public virtual string expiring_synchronization_date { get; set; }
    public virtual long[] journal_ids { get; set; }
    public virtual string provider_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}