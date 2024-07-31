namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class OnboardingProgress
{
    public virtual string onboarding_state { get; set; }
    public virtual bool is_onboarding_closed { get; set; }
    public virtual object company_id { get; set; }
    public virtual object onboarding_id { get; set; }
    public virtual long[] progress_step_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}