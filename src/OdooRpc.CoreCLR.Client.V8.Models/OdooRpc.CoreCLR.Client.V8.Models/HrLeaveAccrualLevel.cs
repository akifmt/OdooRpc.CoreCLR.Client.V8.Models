namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrLeaveAccrualLevel
{
    public virtual long sequence { get; set; }
    public virtual object accrual_plan_id { get; set; }
    public virtual string accrued_gain_time { get; set; }
    public virtual long start_count { get; set; }
    public virtual string start_type { get; set; }
    public virtual double added_value { get; set; }
    public virtual string added_value_type { get; set; }
    public virtual string frequency { get; set; }
    public virtual string week_day { get; set; }
    public virtual long first_day { get; set; }
    public virtual string first_day_display { get; set; }
    public virtual long second_day { get; set; }
    public virtual string second_day_display { get; set; }
    public virtual long first_month_day { get; set; }
    public virtual string first_month_day_display { get; set; }
    public virtual string first_month { get; set; }
    public virtual long second_month_day { get; set; }
    public virtual string second_month_day_display { get; set; }
    public virtual string second_month { get; set; }
    public virtual string yearly_month { get; set; }
    public virtual long yearly_day { get; set; }
    public virtual string yearly_day_display { get; set; }
    public virtual bool cap_accrued_time { get; set; }
    public virtual double maximum_leave { get; set; }
    public virtual string action_with_unused_accruals { get; set; }
    public virtual long postpone_max_days { get; set; }
    public virtual bool can_modify_value_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string frequency_hourly_source { get; set; }
}