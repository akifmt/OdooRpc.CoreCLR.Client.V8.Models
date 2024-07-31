namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpWorkcenterCapacity
{
    public virtual object workcenter_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual double capacity { get; set; }
    public virtual double time_start { get; set; }
    public virtual double time_stop { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}