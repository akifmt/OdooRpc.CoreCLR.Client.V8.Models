namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockInventoryConflict
{
    public virtual long[] quant_ids { get; set; }
    public virtual long[] quant_to_fix_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}