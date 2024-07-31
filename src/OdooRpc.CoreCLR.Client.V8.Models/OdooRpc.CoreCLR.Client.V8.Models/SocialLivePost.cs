namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SocialLivePost
{
    public virtual object post_id { get; set; }
    public virtual object account_id { get; set; }
    public virtual string message { get; set; }
    public virtual string live_post_link { get; set; }
    public virtual string failure_reason { get; set; }
    public virtual string state { get; set; }
    public virtual long engagement { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string facebook_post_id { get; set; }
    public virtual string instagram_post_id { get; set; }
    public virtual string linkedin_post_id { get; set; }
    public virtual string twitter_tweet_id { get; set; }
    public virtual string youtube_video_id { get; set; }
    public virtual long[] reached_visitor_ids { get; set; }
}