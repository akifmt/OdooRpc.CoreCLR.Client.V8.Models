namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductAttribute
{
    public virtual string name { get; set; }
    public virtual string create_variant { get; set; }
    public virtual string display_type { get; set; }
    public virtual long sequence { get; set; }
    public virtual long[] value_ids { get; set; }
    public virtual long[] template_value_ids { get; set; }
    public virtual long[] attribute_line_ids { get; set; }
    public virtual long[] product_tmpl_ids { get; set; }
    public virtual long number_related_products { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string visibility { get; set; }
}