namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockChangeProductQty
{
    public virtual object product_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual long product_variant_count { get; set; }
    public virtual double new_quantity { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}