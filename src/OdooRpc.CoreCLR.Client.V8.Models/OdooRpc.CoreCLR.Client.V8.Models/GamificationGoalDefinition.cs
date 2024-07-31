namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class GamificationGoalDefinition
{
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual bool monetary { get; set; }
    public virtual string suffix { get; set; }
    public virtual string full_suffix { get; set; }
    public virtual string computation_mode { get; set; }
    public virtual string display_mode { get; set; }
    public virtual object model_id { get; set; }
    public virtual long[] model_inherited_ids { get; set; }
    public virtual object field_id { get; set; }
    public virtual object field_date_id { get; set; }
    public virtual string domain { get; set; }
    public virtual bool batch_mode { get; set; }
    public virtual object batch_distinctive_field { get; set; }
    public virtual string batch_user_expression { get; set; }
    public virtual string compute_code { get; set; }
    public virtual string condition { get; set; }
    public virtual object action_id { get; set; }
    public virtual string res_id_field { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}