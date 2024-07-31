namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrApplicantSkill
{
    public virtual object applicant_id { get; set; }
    public virtual object skill_id { get; set; }
    public virtual object skill_level_id { get; set; }
    public virtual object skill_type_id { get; set; }
    public virtual long level_progress { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}