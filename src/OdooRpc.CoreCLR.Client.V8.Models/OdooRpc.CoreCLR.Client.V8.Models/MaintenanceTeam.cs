namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MaintenanceTeam
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] member_ids { get; set; }
    public virtual long color { get; set; }
    public virtual long[] request_ids { get; set; }
    public virtual long[] equipment_ids { get; set; }
    public virtual long[] todo_request_ids { get; set; }
    public virtual long todo_request_count { get; set; }
    public virtual long todo_request_count_date { get; set; }
    public virtual long todo_request_count_high_priority { get; set; }
    public virtual long todo_request_count_block { get; set; }
    public virtual long todo_request_count_unscheduled { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}