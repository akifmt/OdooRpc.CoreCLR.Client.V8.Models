namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PlanningSlotTemplate
{
    public virtual bool active { get; set; }
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual object role_id { get; set; }
    public virtual double start_time { get; set; }
    public virtual double duration { get; set; }
    public virtual double end_time { get; set; }
    public virtual long duration_days { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}