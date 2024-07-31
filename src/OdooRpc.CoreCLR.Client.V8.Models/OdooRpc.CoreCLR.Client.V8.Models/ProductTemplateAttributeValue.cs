namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductTemplateAttributeValue
{
    public virtual bool ptav_active { get; set; }
    public virtual string name { get; set; }
    public virtual object product_attribute_value_id { get; set; }
    public virtual object attribute_line_id { get; set; }
    public virtual double price_extra { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long[] exclude_for { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object attribute_id { get; set; }
    public virtual long[] ptav_product_variant_ids { get; set; }
    public virtual string html_color { get; set; }
    public virtual bool is_custom { get; set; }
    public virtual string display_type { get; set; }
    public virtual long color { get; set; }
    public virtual string image { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}