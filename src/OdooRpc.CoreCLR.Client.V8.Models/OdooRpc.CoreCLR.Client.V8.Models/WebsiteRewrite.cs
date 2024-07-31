namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class WebsiteRewrite
{
    public virtual string name { get; set; }
    public virtual object website_id { get; set; }
    public virtual bool active { get; set; }
    public virtual string url_from { get; set; }
    public virtual object route_id { get; set; }
    public virtual string url_to { get; set; }
    public virtual string redirect_type { get; set; }
    public virtual long sequence { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}