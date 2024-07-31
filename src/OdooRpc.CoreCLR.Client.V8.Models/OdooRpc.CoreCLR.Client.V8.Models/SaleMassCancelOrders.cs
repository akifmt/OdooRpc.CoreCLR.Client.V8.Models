namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleMassCancelOrders
{
    public virtual long[] sale_order_ids { get; set; }
    public virtual long sale_orders_count { get; set; }
    public virtual bool has_confirmed_order { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}