namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpEcoStage
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool folded { get; set; }
    public virtual bool allow_apply_change { get; set; }
    public virtual bool final_stage { get; set; }
    public virtual long[] type_ids { get; set; }
    public virtual long[] approval_template_ids { get; set; }
    public virtual string approval_roles { get; set; }
    public virtual bool is_blocking { get; set; }
    public virtual string legend_blocked { get; set; }
    public virtual string legend_done { get; set; }
    public virtual string legend_normal { get; set; }
    public virtual string description { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}