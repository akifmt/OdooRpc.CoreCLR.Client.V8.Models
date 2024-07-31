namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrLeaveAccrualPlan
{
    public virtual bool active { get; set; }
    public virtual string name { get; set; }
    public virtual object time_off_type_id { get; set; }
    public virtual long employees_count { get; set; }
    public virtual long[] level_ids { get; set; }
    public virtual long[] allocation_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual string transition_mode { get; set; }
    public virtual bool show_transition_mode { get; set; }
    public virtual bool is_based_on_worked_time { get; set; }
    public virtual string accrued_gain_time { get; set; }
    public virtual string carryover_date { get; set; }
    public virtual long carryover_day { get; set; }
    public virtual string carryover_day_display { get; set; }
    public virtual string carryover_month { get; set; }
    public virtual string added_value_type { get; set; }
    public virtual long level_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}