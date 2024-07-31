namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductPublicCategory
{
    public virtual string image_1920 { get; set; }
    public virtual string image_1024 { get; set; }
    public virtual string image_512 { get; set; }
    public virtual string image_256 { get; set; }
    public virtual string image_128 { get; set; }
    public virtual object website_id { get; set; }
    public virtual bool is_seo_optimized { get; set; }
    public virtual string website_meta_title { get; set; }
    public virtual string website_meta_description { get; set; }
    public virtual string website_meta_keywords { get; set; }
    public virtual string website_meta_og_img { get; set; }
    public virtual string seo_name { get; set; }
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] child_id { get; set; }
    public virtual string parent_path { get; set; }
    public virtual long[] parents_and_self { get; set; }
    public virtual long[] product_tmpl_ids { get; set; }
    public virtual string website_description { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}