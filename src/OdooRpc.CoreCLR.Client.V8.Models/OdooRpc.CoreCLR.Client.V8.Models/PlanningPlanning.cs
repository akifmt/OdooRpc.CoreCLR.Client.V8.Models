namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PlanningPlanning
{
    public virtual string start_datetime { get; set; }
    public virtual string end_datetime { get; set; }
    public virtual bool include_unassigned { get; set; }
    public virtual string access_token { get; set; }
    public virtual object company_id { get; set; }
    public virtual string date_start { get; set; }
    public virtual string date_end { get; set; }
    public virtual bool allow_self_unassign { get; set; }
    public virtual long self_unassign_days_before { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}