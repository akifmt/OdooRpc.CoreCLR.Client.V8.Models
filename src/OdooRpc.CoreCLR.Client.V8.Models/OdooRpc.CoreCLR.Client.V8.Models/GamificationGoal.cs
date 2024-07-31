namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class GamificationGoal
{
    public virtual object definition_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual object line_id { get; set; }
    public virtual object challenge_id { get; set; }
    public virtual string start_date { get; set; }
    public virtual string end_date { get; set; }
    public virtual double target_goal { get; set; }
    public virtual double current { get; set; }
    public virtual double completeness { get; set; }
    public virtual string state { get; set; }
    public virtual bool to_update { get; set; }
    public virtual bool closed { get; set; }
    public virtual string computation_mode { get; set; }
    public virtual long remind_update_delay { get; set; }
    public virtual string last_update { get; set; }
    public virtual string definition_description { get; set; }
    public virtual string definition_condition { get; set; }
    public virtual string definition_suffix { get; set; }
    public virtual string definition_display { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}