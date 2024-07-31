namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class WebsitePublishedMultiMixin
{
    public virtual object website_id { get; set; }
    public virtual bool website_published { get; set; }
    public virtual bool is_published { get; set; }
    public virtual bool can_publish { get; set; }
    public virtual string website_url { get; set; }
}