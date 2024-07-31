namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpEcoRoutingChange
{
    public virtual object eco_id { get; set; }
    public virtual string change_type { get; set; }
    public virtual object workcenter_id { get; set; }
    public virtual double old_time_cycle_manual { get; set; }
    public virtual double new_time_cycle_manual { get; set; }
    public virtual double upd_time_cycle_manual { get; set; }
    public virtual object operation_id { get; set; }
    public virtual string operation_name { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object quality_point_id { get; set; }
    public virtual string step { get; set; }
    public virtual object test_type { get; set; }
}