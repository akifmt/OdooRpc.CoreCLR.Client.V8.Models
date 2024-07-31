namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductTag
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual string color { get; set; }
    public virtual long[] product_template_ids { get; set; }
    public virtual long[] product_product_ids { get; set; }
    public virtual long[] product_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object website_id { get; set; }
    public virtual bool visible_on_ecommerce { get; set; }
    public virtual string image { get; set; }
}