namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HelpdeskSlaStatus
{
    public virtual object ticket_id { get; set; }
    public virtual object sla_id { get; set; }
    public virtual object sla_stage_id { get; set; }
    public virtual string deadline { get; set; }
    public virtual string reached_datetime { get; set; }
    public virtual string status { get; set; }
    public virtual long color { get; set; }
    public virtual double exceeded_hours { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}