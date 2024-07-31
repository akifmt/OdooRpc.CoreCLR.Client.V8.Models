namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrLeaveType
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool create_calendar_meeting { get; set; }
    public virtual long color { get; set; }
    public virtual object icon_id { get; set; }
    public virtual bool active { get; set; }
    public virtual bool show_on_dashboard { get; set; }
    public virtual double max_leaves { get; set; }
    public virtual double leaves_taken { get; set; }
    public virtual double virtual_remaining_leaves { get; set; }
    public virtual long allocation_count { get; set; }
    public virtual double group_days_leave { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] responsible_ids { get; set; }
    public virtual string leave_validation_type { get; set; }
    public virtual string requires_allocation { get; set; }
    public virtual string employee_requests { get; set; }
    public virtual string allocation_validation_type { get; set; }
    public virtual bool has_valid_allocation { get; set; }
    public virtual string time_type { get; set; }
    public virtual string request_unit { get; set; }
    public virtual bool unpaid { get; set; }
    public virtual object leave_notif_subtype_id { get; set; }
    public virtual object allocation_notif_subtype_id { get; set; }
    public virtual bool support_document { get; set; }
    public virtual long[] accruals_ids { get; set; }
    public virtual double accrual_count { get; set; }
    public virtual bool allows_negative { get; set; }
    public virtual long max_allowed_negative { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool hr_attendance_overtime { get; set; }
    public virtual bool overtime_deductible { get; set; }
}