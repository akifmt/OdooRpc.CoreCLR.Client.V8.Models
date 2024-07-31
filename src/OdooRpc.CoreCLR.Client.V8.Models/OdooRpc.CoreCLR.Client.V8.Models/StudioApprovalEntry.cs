namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StudioApprovalEntry
{
    public virtual string name { get; set; }
    public virtual object user_id { get; set; }
    public virtual object rule_id { get; set; }
    public virtual string model { get; set; }
    public virtual string method { get; set; }
    public virtual object action_id { get; set; }
    public virtual string res_id { get; set; }
    public virtual string reference { get; set; }
    public virtual bool approved { get; set; }
    public virtual object group_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}