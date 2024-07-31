namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class OnboardingOnboardingStep
{
    public virtual long[] onboarding_ids { get; set; }
    public virtual string title { get; set; }
    public virtual string description { get; set; }
    public virtual string button_text { get; set; }
    public virtual string done_icon { get; set; }
    public virtual string done_text { get; set; }
    public virtual string step_image { get; set; }
    public virtual string step_image_filename { get; set; }
    public virtual string step_image_alt { get; set; }
    public virtual string panel_step_open_action_name { get; set; }
    public virtual object current_progress_step_id { get; set; }
    public virtual string current_step_state { get; set; }
    public virtual long[] progress_ids { get; set; }
    public virtual bool is_per_company { get; set; }
    public virtual long sequence { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}