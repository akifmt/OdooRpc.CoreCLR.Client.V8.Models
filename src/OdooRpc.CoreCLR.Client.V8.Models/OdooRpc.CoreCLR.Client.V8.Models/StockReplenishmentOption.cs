namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockReplenishmentOption
{
    public virtual object route_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object replenishment_info_id { get; set; }
    public virtual object location_id { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual string uom { get; set; }
    public virtual double qty_to_order { get; set; }
    public virtual double free_qty { get; set; }
    public virtual string lead_time { get; set; }
    public virtual string warning_message { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}