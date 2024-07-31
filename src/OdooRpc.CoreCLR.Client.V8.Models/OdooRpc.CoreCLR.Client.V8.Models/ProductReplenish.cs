namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductReplenish
{
    public virtual object product_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual bool product_has_variants { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object forecast_uom_id { get; set; }
    public virtual double quantity { get; set; }
    public virtual string date_planned { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual object route_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual double forecasted_quantity { get; set; }
    public virtual long[] allowed_route_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}