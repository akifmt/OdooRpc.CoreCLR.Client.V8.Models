namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleRentalReport
{
    public virtual string date { get; set; }
    public virtual object order_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_uom { get; set; }
    public virtual double quantity { get; set; }
    public virtual double qty_delivered { get; set; }
    public virtual double qty_returned { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object categ_id { get; set; }
    public virtual string state { get; set; }
    public virtual double price { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object lot_id { get; set; }
}