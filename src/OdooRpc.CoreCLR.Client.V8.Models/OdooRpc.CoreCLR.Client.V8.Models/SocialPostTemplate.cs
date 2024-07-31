namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SocialPostTemplate
{
    public virtual string message { get; set; }
    public virtual long[] image_ids { get; set; }
    public virtual string image_urls { get; set; }
    public virtual long[] account_ids { get; set; }
    public virtual bool has_active_accounts { get; set; }
    public virtual long message_length { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string facebook_preview { get; set; }
    public virtual bool display_facebook_preview { get; set; }
    public virtual object instagram_image_id { get; set; }
    public virtual string instagram_access_token { get; set; }
    public virtual bool display_instagram_preview { get; set; }
    public virtual string instagram_preview { get; set; }
    public virtual bool display_linkedin_preview { get; set; }
    public virtual string linkedin_preview { get; set; }
    public virtual string twitter_preview { get; set; }
    public virtual bool has_twitter_accounts { get; set; }
    public virtual string twitter_post_limit_message { get; set; }
    public virtual bool is_twitter_post_limit_exceed { get; set; }
    public virtual bool display_push_notification_attributes { get; set; }
    public virtual string push_notification_title { get; set; }
    public virtual string push_notification_target_url { get; set; }
    public virtual string push_notification_image { get; set; }
    public virtual bool display_push_notifications_preview { get; set; }
    public virtual string push_notifications_preview { get; set; }
    public virtual bool use_visitor_timezone { get; set; }
    public virtual string visitor_domain { get; set; }
}