namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class GamificationKarmaTracking
{
    public virtual object user_id { get; set; }
    public virtual long old_value { get; set; }
    public virtual long new_value { get; set; }
    public virtual long gain { get; set; }
    public virtual bool consolidated { get; set; }
    public virtual string tracking_date { get; set; }
    public virtual string reason { get; set; }
    public virtual string origin_ref { get; set; }
    public virtual string origin_ref_model_name { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}