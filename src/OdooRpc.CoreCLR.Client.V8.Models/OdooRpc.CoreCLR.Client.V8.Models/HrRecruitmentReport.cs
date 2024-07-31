namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrRecruitmentReport
{
    public virtual long count { get; set; }
    public virtual long refused { get; set; }
    public virtual long hired { get; set; }
    public virtual long hiring_ratio { get; set; }
    public virtual long meetings_amount { get; set; }
    public virtual string state { get; set; }
    public virtual object user_id { get; set; }
    public virtual string create_date { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string date_closed { get; set; }
    public virtual object stage_id { get; set; }
    public virtual string name { get; set; }
    public virtual object job_id { get; set; }
    public virtual object medium_id { get; set; }
    public virtual object source_id { get; set; }
    public virtual long process_duration { get; set; }
    public virtual object refuse_reason_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual long has_referrer { get; set; }
    public virtual long referral_hired { get; set; }
}