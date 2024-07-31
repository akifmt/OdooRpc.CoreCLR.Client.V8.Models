namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpProductionBackorder
{
    public virtual long[] mrp_production_ids { get; set; }
    public virtual long[] mrp_production_backorder_line_ids { get; set; }
    public virtual bool show_backorder_lines { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}