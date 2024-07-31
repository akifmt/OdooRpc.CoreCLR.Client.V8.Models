namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StudioApprovalRule
{
    public virtual bool active { get; set; }
    public virtual object group_id { get; set; }
    public virtual object model_id { get; set; }
    public virtual string method { get; set; }
    public virtual object action_id { get; set; }
    public virtual string name { get; set; }
    public virtual string message { get; set; }
    public virtual object responsible_id { get; set; }
    public virtual long[] users_to_notify { get; set; }
    public virtual string notification_order { get; set; }
    public virtual bool exclusive_user { get; set; }
    public virtual string model_name { get; set; }
    public virtual string domain { get; set; }
    public virtual bool conditional { get; set; }
    public virtual bool can_validate { get; set; }
    public virtual long[] entry_ids { get; set; }
    public virtual long entries_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}