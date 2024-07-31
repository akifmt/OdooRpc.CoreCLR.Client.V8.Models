namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpEcoApproval
{
    public virtual object eco_id { get; set; }
    public virtual object approval_template_id { get; set; }
    public virtual string name { get; set; }
    public virtual object user_id { get; set; }
    public virtual long[] required_user_ids { get; set; }
    public virtual object template_stage_id { get; set; }
    public virtual object eco_stage_id { get; set; }
    public virtual string status { get; set; }
    public virtual string approval_date { get; set; }
    public virtual bool is_closed { get; set; }
    public virtual bool is_approved { get; set; }
    public virtual bool is_rejected { get; set; }
    public virtual bool awaiting_my_validation { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}