namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductImage
{
    public virtual string image_1920 { get; set; }
    public virtual string image_1024 { get; set; }
    public virtual string image_512 { get; set; }
    public virtual string image_256 { get; set; }
    public virtual string image_128 { get; set; }
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object product_variant_id { get; set; }
    public virtual string video_url { get; set; }
    public virtual string embed_code { get; set; }
    public virtual bool can_image_1024_be_zoomed { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}