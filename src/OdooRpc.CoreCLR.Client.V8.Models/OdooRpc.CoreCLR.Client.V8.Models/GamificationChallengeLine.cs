namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class GamificationChallengeLine
{
    public virtual object challenge_id { get; set; }
    public virtual object definition_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual double target_goal { get; set; }
    public virtual string name { get; set; }
    public virtual string condition { get; set; }
    public virtual string definition_suffix { get; set; }
    public virtual bool definition_monetary { get; set; }
    public virtual string definition_full_suffix { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}