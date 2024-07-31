namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProjectTaskBurndownChartReport
{
    public virtual double allocated_hours { get; set; }
    public virtual string date { get; set; }
    public virtual string date_assign { get; set; }
    public virtual string date_deadline { get; set; }
    public virtual string date_last_stage_update { get; set; }
    public virtual string state { get; set; }
    public virtual string is_closed { get; set; }
    public virtual object milestone_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object project_id { get; set; }
    public virtual object stage_id { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual long[] user_ids { get; set; }
}