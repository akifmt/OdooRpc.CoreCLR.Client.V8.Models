namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SocialStream
{
    public virtual string name { get; set; }
    public virtual object media_id { get; set; }
    public virtual string media_image { get; set; }
    public virtual long sequence { get; set; }
    public virtual object account_id { get; set; }
    public virtual object stream_type_id { get; set; }
    public virtual string stream_type_type { get; set; }
    public virtual long[] stream_post_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string twitter_searched_keyword { get; set; }
    public virtual string twitter_followed_account_search { get; set; }
    public virtual object twitter_followed_account_id { get; set; }
}