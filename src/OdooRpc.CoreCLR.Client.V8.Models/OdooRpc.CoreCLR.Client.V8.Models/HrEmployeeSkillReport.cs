namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrEmployeeSkillReport
{
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object employee_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object department_id { get; set; }
    public virtual object skill_id { get; set; }
    public virtual object skill_type_id { get; set; }
    public virtual string skill_level { get; set; }
    public virtual double level_progress { get; set; }
    public virtual bool active { get; set; }
}