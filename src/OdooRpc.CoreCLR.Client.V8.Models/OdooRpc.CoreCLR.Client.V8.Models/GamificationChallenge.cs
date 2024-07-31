namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class GamificationChallenge
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
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual string state { get; set; }
    public virtual object manager_id { get; set; }
    public virtual long[] user_ids { get; set; }
    public virtual string user_domain { get; set; }
    public virtual long user_count { get; set; }
    public virtual string period { get; set; }
    public virtual string start_date { get; set; }
    public virtual string end_date { get; set; }
    public virtual long[] invited_user_ids { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual object reward_id { get; set; }
    public virtual object reward_first_id { get; set; }
    public virtual object reward_second_id { get; set; }
    public virtual object reward_third_id { get; set; }
    public virtual bool reward_failure { get; set; }
    public virtual bool reward_realtime { get; set; }
    public virtual string visibility_mode { get; set; }
    public virtual string report_message_frequency { get; set; }
    public virtual object report_message_group_id { get; set; }
    public virtual object report_template_id { get; set; }
    public virtual long remind_update_delay { get; set; }
    public virtual string last_report_date { get; set; }
    public virtual string next_report_date { get; set; }
    public virtual string challenge_category { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}