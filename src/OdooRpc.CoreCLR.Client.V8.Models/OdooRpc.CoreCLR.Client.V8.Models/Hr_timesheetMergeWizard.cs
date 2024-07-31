namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Hr_timesheetMergeWizard
{
    public virtual string name { get; set; }
    public virtual long[] timesheet_ids { get; set; }
    public virtual string date { get; set; }
    public virtual double unit_amount { get; set; }
    public virtual object encoding_uom_id { get; set; }
    public virtual object project_id { get; set; }
    public virtual object task_id { get; set; }
    public virtual object employee_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}