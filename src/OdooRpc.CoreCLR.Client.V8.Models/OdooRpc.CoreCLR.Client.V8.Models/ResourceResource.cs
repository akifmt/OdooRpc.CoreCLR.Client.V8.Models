namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResourceResource
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual string resource_type { get; set; }
    public virtual object user_id { get; set; }
    public virtual string avatar_128 { get; set; }
    public virtual bool share { get; set; }
    public virtual string email { get; set; }
    public virtual string phone { get; set; }
    public virtual double time_efficiency { get; set; }
    public virtual object calendar_id { get; set; }
    public virtual string tz { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string im_status { get; set; }
    public virtual long[] employee_id { get; set; }
    public virtual string job_title { get; set; }
    public virtual object department_id { get; set; }
    public virtual string work_email { get; set; }
    public virtual string work_phone { get; set; }
    public virtual bool show_hr_icon_display { get; set; }
    public virtual string hr_icon_display { get; set; }
    public virtual long[] employee_skill_ids { get; set; }
    public virtual long color { get; set; }
    public virtual long[] role_ids { get; set; }
    public virtual object default_role_id { get; set; }
}