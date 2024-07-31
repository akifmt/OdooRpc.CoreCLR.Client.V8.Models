namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class TimesheetsAnalysisReport
{
    public virtual string name { get; set; }
    public virtual object user_id { get; set; }
    public virtual object project_id { get; set; }
    public virtual object task_id { get; set; }
    public virtual object parent_task_id { get; set; }
    public virtual object employee_id { get; set; }
    public virtual object manager_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object department_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string date { get; set; }
    public virtual string amount { get; set; }
    public virtual double unit_amount { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object milestone_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual bool validated { get; set; }
    public virtual bool is_timesheet { get; set; }
    public virtual bool is_timer_running { get; set; }
    public virtual object order_id { get; set; }
    public virtual object so_line { get; set; }
    public virtual string timesheet_invoice_type { get; set; }
    public virtual object timesheet_invoice_id { get; set; }
    public virtual double timesheet_revenues { get; set; }
    public virtual double margin { get; set; }
    public virtual double billable_time { get; set; }
    public virtual double non_billable_time { get; set; }
}