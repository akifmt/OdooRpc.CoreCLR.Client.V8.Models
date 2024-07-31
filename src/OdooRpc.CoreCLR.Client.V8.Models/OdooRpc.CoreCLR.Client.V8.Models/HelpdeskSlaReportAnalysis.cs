namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HelpdeskSlaReportAnalysis
{
    public virtual object ticket_id { get; set; }
    public virtual string description { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual string ticket_ref { get; set; }
    public virtual string name { get; set; }
    public virtual string create_date { get; set; }
    public virtual string priority { get; set; }
    public virtual object user_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string partner_name { get; set; }
    public virtual string partner_email { get; set; }
    public virtual string partner_phone { get; set; }
    public virtual object stage_id { get; set; }
    public virtual double ticket_open_hours { get; set; }
    public virtual bool ticket_closed { get; set; }
    public virtual long ticket_close_hours { get; set; }
    public virtual long ticket_assignation_hours { get; set; }
    public virtual string close_date { get; set; }
    public virtual object sla_id { get; set; }
    public virtual long[] sla_ids { get; set; }
    public virtual long[] sla_status_ids { get; set; }
    public virtual object sla_stage_id { get; set; }
    public virtual string sla_deadline { get; set; }
    public virtual string sla_status { get; set; }
    public virtual bool sla_fail { get; set; }
    public virtual bool sla_success { get; set; }
    public virtual long sla_exceeded_hours { get; set; }
    public virtual long sla_status_failed { get; set; }
    public virtual bool active { get; set; }
    public virtual double rating_last_value { get; set; }
    public virtual double rating_avg { get; set; }
    public virtual object team_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual bool message_is_follower { get; set; }
    public virtual string kanban_state { get; set; }
    public virtual double avg_response_hours { get; set; }
    public virtual double first_response_hours { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}