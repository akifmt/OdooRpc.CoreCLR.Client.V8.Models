namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class OnboardingOnboarding
{
    public virtual string name { get; set; }
    public virtual string route_name { get; set; }
    public virtual long[] step_ids { get; set; }
    public virtual string text_completed { get; set; }
    public virtual bool is_per_company { get; set; }
    public virtual string panel_close_action_name { get; set; }
    public virtual object current_progress_id { get; set; }
    public virtual string current_onboarding_state { get; set; }
    public virtual bool is_onboarding_closed { get; set; }
    public virtual long[] progress_ids { get; set; }
    public virtual long sequence { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}