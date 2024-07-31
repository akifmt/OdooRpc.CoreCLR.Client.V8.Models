namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PlanningRecurrency
{
    public virtual long[] slot_ids { get; set; }
    public virtual long repeat_interval { get; set; }
    public virtual string repeat_unit { get; set; }
    public virtual string repeat_type { get; set; }
    public virtual string repeat_until { get; set; }
    public virtual long repeat_number { get; set; }
    public virtual string last_generated_end_datetime { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}