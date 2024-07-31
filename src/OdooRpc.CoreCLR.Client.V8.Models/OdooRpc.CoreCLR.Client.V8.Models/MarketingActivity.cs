namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MarketingActivity
{
    public virtual string name { get; set; }
    public virtual object source_id { get; set; }
    public virtual string activity_type { get; set; }
    public virtual object mass_mailing_id { get; set; }
    public virtual string mass_mailing_id_mailing_type { get; set; }
    public virtual object server_action_id { get; set; }
    public virtual object campaign_id { get; set; }
    public virtual object utm_campaign_id { get; set; }
    public virtual long interval_number { get; set; }
    public virtual string interval_type { get; set; }
    public virtual long interval_standardized { get; set; }
    public virtual bool validity_duration { get; set; }
    public virtual long validity_duration_number { get; set; }
    public virtual string validity_duration_type { get; set; }
    public virtual string domain { get; set; }
    public virtual string activity_domain { get; set; }
    public virtual object model_id { get; set; }
    public virtual string model_name { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] allowed_parent_ids { get; set; }
    public virtual long[] child_ids { get; set; }
    public virtual string trigger_type { get; set; }
    public virtual string trigger_category { get; set; }
    public virtual bool require_sync { get; set; }
    public virtual long[] trace_ids { get; set; }
    public virtual long processed { get; set; }
    public virtual long rejected { get; set; }
    public virtual long total_sent { get; set; }
    public virtual long total_click { get; set; }
    public virtual long total_open { get; set; }
    public virtual long total_reply { get; set; }
    public virtual long total_bounce { get; set; }
    public virtual string statistics_graph_data { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}