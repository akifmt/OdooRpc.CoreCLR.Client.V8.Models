namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockReturnPicking
{
    public virtual object picking_id { get; set; }
    public virtual long[] product_return_moves { get; set; }
    public virtual bool move_dest_exists { get; set; }
    public virtual object original_location_id { get; set; }
    public virtual object parent_location_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object location_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}