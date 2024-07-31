namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SocialTwitterAccount
{
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual string twitter_id { get; set; }
    public virtual string image { get; set; }
    public virtual object twitter_searched_by_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}