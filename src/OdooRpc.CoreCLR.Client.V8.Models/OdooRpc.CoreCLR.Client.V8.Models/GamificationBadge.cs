namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class GamificationBadge
{
    public virtual bool website_published { get; set; }
    public virtual bool is_published { get; set; }
    public virtual bool can_publish { get; set; }
    public virtual string website_url { get; set; }
    public virtual string image_1920 { get; set; }
    public virtual string image_1024 { get; set; }
    public virtual string image_512 { get; set; }
    public virtual string image_256 { get; set; }
    public virtual string image_128 { get; set; }
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
    public virtual bool active { get; set; }
    public virtual string description { get; set; }
    public virtual string level { get; set; }
    public virtual string rule_auth { get; set; }
    public virtual long[] rule_auth_user_ids { get; set; }
    public virtual long[] rule_auth_badge_ids { get; set; }
    public virtual bool rule_max { get; set; }
    public virtual long rule_max_number { get; set; }
    public virtual long[] challenge_ids { get; set; }
    public virtual long[] goal_definition_ids { get; set; }
    public virtual long[] owner_ids { get; set; }
    public virtual long granted_count { get; set; }
    public virtual long granted_users_count { get; set; }
    public virtual long[] unique_owner_ids { get; set; }
    public virtual long stat_this_month { get; set; }
    public virtual long stat_my { get; set; }
    public virtual long stat_my_this_month { get; set; }
    public virtual long stat_my_monthly_sending { get; set; }
    public virtual long remaining_sending { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] survey_ids { get; set; }
    public virtual object survey_id { get; set; }
    public virtual long granted_employees_count { get; set; }
}