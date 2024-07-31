namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrRecruitmentStageReport
{
    public virtual object applicant_id { get; set; }
    public virtual string name { get; set; }
    public virtual object stage_id { get; set; }
    public virtual object job_id { get; set; }
    public virtual double days_in_stage { get; set; }
    public virtual string state { get; set; }
    public virtual object company_id { get; set; }
    public virtual string date_begin { get; set; }
    public virtual string date_end { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}