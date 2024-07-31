namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PlanningRole
{
    public virtual bool active { get; set; }
    public virtual string name { get; set; }
    public virtual long color { get; set; }
    public virtual long[] resource_ids { get; set; }
    public virtual long sequence { get; set; }
    public virtual string slot_properties_definition { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}