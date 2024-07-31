namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleOrderOption
{
    public virtual object order_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object line_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual string name { get; set; }
    public virtual double quantity { get; set; }
    public virtual object uom_id { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual double price_unit { get; set; }
    public virtual double discount { get; set; }
    public virtual bool is_present { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}