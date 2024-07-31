namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PlanningAnalysisReport
{
    public virtual double allocated_hours { get; set; }
    public virtual double allocated_percentage { get; set; }
    public virtual object company_id { get; set; }
    public virtual object department_id { get; set; }
    public virtual object employee_id { get; set; }
    public virtual string end_datetime { get; set; }
    public virtual string job_title { get; set; }
    public virtual object manager_id { get; set; }
    public virtual string name { get; set; }
    public virtual bool publication_warning { get; set; }
    public virtual object recurrency_id { get; set; }
    public virtual object resource_id { get; set; }
    public virtual string resource_type { get; set; }
    public virtual object role_id { get; set; }
    public virtual string start_datetime { get; set; }
    public virtual string state { get; set; }
    public virtual object user_id { get; set; }
    public virtual double working_days_count { get; set; }
    public virtual object slot_id { get; set; }
    public virtual bool request_to_switch { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual long[] employee_skill_ids { get; set; }
}