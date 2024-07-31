namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class LinkTracker
{
    public virtual object campaign_id { get; set; }
    public virtual object source_id { get; set; }
    public virtual object medium_id { get; set; }
    public virtual string url { get; set; }
    public virtual string absolute_url { get; set; }
    public virtual string short_url { get; set; }
    public virtual string redirected_url { get; set; }
    public virtual string short_url_host { get; set; }
    public virtual string title { get; set; }
    public virtual string label { get; set; }
    public virtual long[] link_code_ids { get; set; }
    public virtual string code { get; set; }
    public virtual long[] link_click_ids { get; set; }
    public virtual long count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object mass_mailing_id { get; set; }
}