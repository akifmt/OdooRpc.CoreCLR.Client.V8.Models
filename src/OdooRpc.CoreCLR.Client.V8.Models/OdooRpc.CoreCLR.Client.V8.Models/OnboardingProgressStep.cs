namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class OnboardingProgressStep
{
    public virtual long[] progress_ids { get; set; }
    public virtual string step_state { get; set; }
    public virtual object step_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}