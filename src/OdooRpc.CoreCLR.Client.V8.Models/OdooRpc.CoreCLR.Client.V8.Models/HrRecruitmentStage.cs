namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrRecruitmentStage
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual long[] job_ids { get; set; }
    public virtual string requirements { get; set; }
    public virtual object template_id { get; set; }
    public virtual bool fold { get; set; }
    public virtual bool hired_stage { get; set; }
    public virtual string legend_blocked { get; set; }
    public virtual string legend_done { get; set; }
    public virtual string legend_normal { get; set; }
    public virtual bool is_warning_visible { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long points { get; set; }
    public virtual bool use_in_referral { get; set; }
}