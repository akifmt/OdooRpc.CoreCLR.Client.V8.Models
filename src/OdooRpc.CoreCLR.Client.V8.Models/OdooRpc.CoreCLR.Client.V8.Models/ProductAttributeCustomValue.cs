namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductAttributeCustomValue
{
    public virtual string name { get; set; }
    public virtual object custom_product_template_attribute_value_id { get; set; }
    public virtual string custom_value { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object sale_order_line_id { get; set; }
}