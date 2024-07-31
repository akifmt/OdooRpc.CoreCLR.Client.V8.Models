namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ThemeWebsitePage
{
    public virtual string url { get; set; }
    public virtual object view_id { get; set; }
    public virtual bool website_indexed { get; set; }
    public virtual bool is_published { get; set; }
    public virtual bool header_overlay { get; set; }
    public virtual string header_color { get; set; }
    public virtual bool header_visible { get; set; }
    public virtual bool footer_visible { get; set; }
    public virtual long[] copy_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}