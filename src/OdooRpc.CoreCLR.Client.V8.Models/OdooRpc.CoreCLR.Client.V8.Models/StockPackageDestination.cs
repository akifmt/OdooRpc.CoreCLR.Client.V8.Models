namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockPackageDestination
{
    public virtual object picking_id { get; set; }
    public virtual long[] move_line_ids { get; set; }
    public virtual object location_dest_id { get; set; }
    public virtual long[] filtered_location { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}