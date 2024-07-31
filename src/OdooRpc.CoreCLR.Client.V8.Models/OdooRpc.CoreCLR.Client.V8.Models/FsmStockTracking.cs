namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class FsmStockTracking
{
    public virtual object task_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual string tracking { get; set; }
    public virtual long[] tracking_line_ids { get; set; }
    public virtual long[] tracking_validated_line_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual bool is_same_warehouse { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}