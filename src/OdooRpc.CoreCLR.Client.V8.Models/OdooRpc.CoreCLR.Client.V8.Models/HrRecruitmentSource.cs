namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrRecruitmentSource
{
    public virtual string name { get; set; }
    public virtual object source_id { get; set; }
    public virtual string email { get; set; }
    public virtual string has_domain { get; set; }
    public virtual object job_id { get; set; }
    public virtual object alias_id { get; set; }
    public virtual object medium_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string url { get; set; }
}