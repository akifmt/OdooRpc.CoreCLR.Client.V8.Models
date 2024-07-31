namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SlideSlidePartner
{
    public virtual object slide_id { get; set; }
    public virtual string slide_category { get; set; }
    public virtual object channel_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual long vote { get; set; }
    public virtual bool completed { get; set; }
    public virtual long quiz_attempts_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] user_input_ids { get; set; }
    public virtual bool survey_scoring_success { get; set; }
}