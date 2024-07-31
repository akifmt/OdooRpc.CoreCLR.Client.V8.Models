namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrFilters
{
    public virtual string name { get; set; }
    public virtual object user_id { get; set; }
    public virtual string domain { get; set; }
    public virtual string context { get; set; }
    public virtual string sort { get; set; }
    public virtual string model_id { get; set; }
    public virtual bool is_default { get; set; }
    public virtual object action_id { get; set; }
    public virtual bool active { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}