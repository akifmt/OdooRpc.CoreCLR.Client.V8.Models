namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockWarehouseOrderpoint
{
    public virtual string name { get; set; }
    public virtual string trigger { get; set; }
    public virtual bool active { get; set; }
    public virtual string snoozed_until { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual object location_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_category_id { get; set; }
    public virtual object product_uom { get; set; }
    public virtual string product_uom_name { get; set; }
    public virtual double product_min_qty { get; set; }
    public virtual double product_max_qty { get; set; }
    public virtual double qty_multiple { get; set; }
    public virtual object group_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] allowed_location_ids { get; set; }
    public virtual long[] rule_ids { get; set; }
    public virtual string lead_days_date { get; set; }
    public virtual object route_id { get; set; }
    public virtual double qty_on_hand { get; set; }
    public virtual double qty_forecast { get; set; }
    public virtual double qty_to_order { get; set; }
    public virtual double days_to_order { get; set; }
    public virtual double visibility_days { get; set; }
    public virtual bool unwanted_replenish { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}