namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class WebsiteTrack
{
    public virtual object visitor_id { get; set; }
    public virtual object page_id { get; set; }
    public virtual string url { get; set; }
    public virtual string visit_datetime { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object product_id { get; set; }
}