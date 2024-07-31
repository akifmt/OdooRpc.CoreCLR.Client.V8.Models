namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrAppraisalSkillReport
{
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual string create_date { get; set; }
    public virtual object employee_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object department_id { get; set; }
    public virtual object skill_id { get; set; }
    public virtual object skill_type_id { get; set; }
    public virtual object previous_skill_level_id { get; set; }
    public virtual double previous_level_progress { get; set; }
    public virtual object current_skill_level_id { get; set; }
    public virtual double current_level_progress { get; set; }
    public virtual string justification { get; set; }
    public virtual long evolution_sequence { get; set; }
    public virtual string evolution { get; set; }
    public virtual double progress_evolution { get; set; }
}