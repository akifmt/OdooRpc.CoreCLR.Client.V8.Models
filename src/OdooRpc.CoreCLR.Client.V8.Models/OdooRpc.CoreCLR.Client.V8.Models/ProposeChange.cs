namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProposeChange
{
    public virtual object workorder_id { get; set; }
    public virtual string title { get; set; }
    public virtual object step_id { get; set; }
    public virtual string note { get; set; }
    public virtual string comment { get; set; }
    public virtual string picture { get; set; }
    public virtual string change_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}