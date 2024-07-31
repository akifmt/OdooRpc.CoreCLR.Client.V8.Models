namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockWarnInsufficientQty
{
    public virtual object product_id { get; set; }
    public virtual object location_id { get; set; }
    public virtual long[] quant_ids { get; set; }
    public virtual double quantity { get; set; }
    public virtual string product_uom_name { get; set; }
}