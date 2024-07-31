namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MaintenanceMixin
{
    public virtual object company_id { get; set; }
    public virtual string effective_date { get; set; }
    public virtual object maintenance_team_id { get; set; }
    public virtual object technician_user_id { get; set; }
    public virtual long[] maintenance_ids { get; set; }
    public virtual long maintenance_count { get; set; }
    public virtual long maintenance_open_count { get; set; }
    public virtual long expected_mtbf { get; set; }
    public virtual long mtbf { get; set; }
    public virtual long mttr { get; set; }
    public virtual string estimated_next_failure { get; set; }
    public virtual string latest_failure_date { get; set; }
}