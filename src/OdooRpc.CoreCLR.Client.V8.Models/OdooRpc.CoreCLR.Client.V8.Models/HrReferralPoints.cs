namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrReferralPoints
{
    public virtual object applicant_id { get; set; }
    public virtual string applicant_subject { get; set; }
    public virtual string applicant_name { get; set; }
    public virtual object hr_referral_reward_id { get; set; }
    public virtual object ref_user_id { get; set; }
    public virtual long points { get; set; }
    public virtual object stage_id { get; set; }
    public virtual long sequence_stage { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}