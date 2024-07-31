namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrLeaveReport
{
    public virtual object employee_id { get; set; }
    public virtual object leave_id { get; set; }
    public virtual string name { get; set; }
    public virtual double number_of_days { get; set; }
    public virtual double number_of_hours { get; set; }
    public virtual string leave_type { get; set; }
    public virtual object department_id { get; set; }
    public virtual object category_id { get; set; }
    public virtual object holiday_status_id { get; set; }
    public virtual string state { get; set; }
    public virtual string holiday_type { get; set; }
    public virtual string date_from { get; set; }
    public virtual string date_to { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}