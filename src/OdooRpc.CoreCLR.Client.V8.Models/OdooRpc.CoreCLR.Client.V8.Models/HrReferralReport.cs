namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrReferralReport
{
    public virtual string write_date { get; set; }
    public virtual long earned_points { get; set; }
    public virtual long points_not_hired { get; set; }
    public virtual object applicant_id { get; set; }
    public virtual long employee_referral_hired { get; set; }
    public virtual long employee_referral_refused { get; set; }
    public virtual object ref_user_id { get; set; }
    public virtual object job_id { get; set; }
    public virtual object department_id { get; set; }
    public virtual object medium_id { get; set; }
    public virtual string referral_state { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}