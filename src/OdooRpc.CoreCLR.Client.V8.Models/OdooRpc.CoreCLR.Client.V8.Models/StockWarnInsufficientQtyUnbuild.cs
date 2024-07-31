namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockWarnInsufficientQtyUnbuild
{
    public virtual object product_id { get; set; }
    public virtual object location_id { get; set; }
    public virtual long[] quant_ids { get; set; }
    public virtual double quantity { get; set; }
    public virtual string product_uom_name { get; set; }
    public virtual object unbuild_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}