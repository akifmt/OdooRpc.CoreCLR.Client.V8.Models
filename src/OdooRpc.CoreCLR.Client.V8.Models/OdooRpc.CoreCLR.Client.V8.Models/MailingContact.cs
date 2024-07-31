namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailingContact
{
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
    public virtual string phone_sanitized { get; set; }
    public virtual bool phone_sanitized_blacklisted { get; set; }
    public virtual bool phone_blacklisted { get; set; }
    public virtual bool mobile_blacklisted { get; set; }
    public virtual string phone_mobile_search { get; set; }
    public virtual string email_normalized { get; set; }
    public virtual bool is_blacklisted { get; set; }
    public virtual long message_bounce { get; set; }
    public virtual string name { get; set; }
    public virtual string first_name { get; set; }
    public virtual string last_name { get; set; }
    public virtual string company_name { get; set; }
    public virtual object title_id { get; set; }
    public virtual string email { get; set; }
    public virtual long[] list_ids { get; set; }
    public virtual long[] subscription_ids { get; set; }
    public virtual object country_id { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual bool opt_out { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string mobile { get; set; }
}