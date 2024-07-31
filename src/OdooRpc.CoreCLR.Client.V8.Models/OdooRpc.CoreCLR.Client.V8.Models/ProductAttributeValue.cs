namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductAttributeValue
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual object attribute_id { get; set; }
    public virtual long[] pav_attribute_line_ids { get; set; }
    public virtual bool is_used_on_products { get; set; }
    public virtual double default_extra_price { get; set; }
    public virtual bool is_custom { get; set; }
    public virtual string html_color { get; set; }
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