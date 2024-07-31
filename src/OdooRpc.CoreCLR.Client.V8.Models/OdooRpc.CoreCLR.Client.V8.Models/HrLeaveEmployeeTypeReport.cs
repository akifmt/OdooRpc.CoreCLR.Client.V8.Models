namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrLeaveEmployeeTypeReport
{
    public virtual object employee_id { get; set; }
    public virtual bool active_employee { get; set; }
    public virtual double number_of_days { get; set; }
    public virtual double number_of_hours { get; set; }
    public virtual object department_id { get; set; }
    public virtual object leave_type { get; set; }
    public virtual string holiday_status { get; set; }
    public virtual string state { get; set; }
    public virtual string date_from { get; set; }
    public virtual string date_to { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}