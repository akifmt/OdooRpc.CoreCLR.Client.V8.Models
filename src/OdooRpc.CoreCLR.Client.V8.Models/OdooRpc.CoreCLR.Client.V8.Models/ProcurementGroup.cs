namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProcurementGroup
{
    public virtual object partner_id { get; set; }
    public virtual string name { get; set; }
    public virtual string move_type { get; set; }
    public virtual long[] stock_move_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object pos_order_id { get; set; }
    public virtual object sale_id { get; set; }
}