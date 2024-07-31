namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockRulesReport
{
    public virtual object product_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual long[] warehouse_ids { get; set; }
    public virtual bool product_has_variants { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] so_route_ids { get; set; }
}