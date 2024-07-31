namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrLeaveReportCalendar
{
    public virtual string name { get; set; }
    public virtual string start_datetime { get; set; }
    public virtual string stop_datetime { get; set; }
    public virtual string tz { get; set; }
    public virtual double duration { get; set; }
    public virtual object employee_id { get; set; }
    public virtual object department_id { get; set; }
    public virtual object job_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string state { get; set; }
    public virtual bool is_hatched { get; set; }
    public virtual bool is_striked { get; set; }
    public virtual bool is_absent { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}