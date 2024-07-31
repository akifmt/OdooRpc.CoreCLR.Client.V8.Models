namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockReplenishmentInfo
{
    public virtual object orderpoint_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual double qty_to_order { get; set; }
    public virtual string json_lead_days { get; set; }
    public virtual string json_replenishment_history { get; set; }
    public virtual long[] warehouseinfo_ids { get; set; }
    public virtual long[] wh_replenishment_option_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}