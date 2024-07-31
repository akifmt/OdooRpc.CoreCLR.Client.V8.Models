namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class WebsiteSeoMetadata
{
    public virtual bool is_seo_optimized { get; set; }
    public virtual string website_meta_title { get; set; }
    public virtual string website_meta_description { get; set; }
    public virtual string website_meta_keywords { get; set; }
    public virtual string website_meta_og_img { get; set; }
    public virtual string seo_name { get; set; }
}