namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class FsmStockTrackingLine
{
    public virtual object lot_id { get; set; }
    public virtual double quantity { get; set; }
    public virtual object product_id { get; set; }
    public virtual object sale_order_line_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object wizard_tracking_line { get; set; }
    public virtual object wizard_tracking_line_validated { get; set; }
    public virtual bool is_same_warehouse { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}