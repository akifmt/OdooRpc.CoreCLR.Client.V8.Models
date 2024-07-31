namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SocialAccount
{
    public virtual string name { get; set; }
    public virtual string social_account_handle { get; set; }
    public virtual bool active { get; set; }
    public virtual object media_id { get; set; }
    public virtual string media_type { get; set; }
    public virtual string stats_link { get; set; }
    public virtual string image { get; set; }
    public virtual bool is_media_disconnected { get; set; }
    public virtual long audience { get; set; }
    public virtual double audience_trend { get; set; }
    public virtual long engagement { get; set; }
    public virtual double engagement_trend { get; set; }
    public virtual long stories { get; set; }
    public virtual double stories_trend { get; set; }
    public virtual bool has_trends { get; set; }
    public virtual bool has_account_stats { get; set; }
    public virtual object utm_medium_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string facebook_account_id { get; set; }
    public virtual string facebook_access_token { get; set; }
    public virtual string instagram_account_id { get; set; }
    public virtual string instagram_facebook_account_id { get; set; }
    public virtual string instagram_access_token { get; set; }
    public virtual string linkedin_account_urn { get; set; }
    public virtual string linkedin_account_id { get; set; }
    public virtual string linkedin_access_token { get; set; }
    public virtual string twitter_user_id { get; set; }
    public virtual string twitter_oauth_token { get; set; }
    public virtual string twitter_oauth_token_secret { get; set; }
    public virtual string youtube_channel_id { get; set; }
    public virtual string youtube_access_token { get; set; }
    public virtual string youtube_refresh_token { get; set; }
    public virtual string youtube_token_expiration_date { get; set; }
    public virtual string youtube_upload_playlist_id { get; set; }
    public virtual object website_id { get; set; }
    public virtual bool firebase_use_own_account { get; set; }
    public virtual string firebase_project_id { get; set; }
    public virtual string firebase_web_api_key { get; set; }
    public virtual string firebase_push_certificate_key { get; set; }
    public virtual string firebase_sender_id { get; set; }
    public virtual string firebase_admin_key_file { get; set; }
    public virtual string notification_request_title { get; set; }
    public virtual string notification_request_body { get; set; }
    public virtual long notification_request_delay { get; set; }
    public virtual string notification_request_icon { get; set; }
}