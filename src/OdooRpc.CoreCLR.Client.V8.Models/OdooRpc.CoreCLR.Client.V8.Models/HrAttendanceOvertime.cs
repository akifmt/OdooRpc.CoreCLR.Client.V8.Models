namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrAttendanceOvertime
{
    public virtual object employee_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string date { get; set; }
    public virtual double duration { get; set; }
    public virtual double duration_real { get; set; }
    public virtual bool adjustment { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}