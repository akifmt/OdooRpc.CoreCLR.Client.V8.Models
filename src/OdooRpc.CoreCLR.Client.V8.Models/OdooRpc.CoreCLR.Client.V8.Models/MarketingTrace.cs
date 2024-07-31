namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MarketingTrace
{
    public virtual object participant_id { get; set; }
    public virtual long res_id { get; set; }
    public virtual bool is_test { get; set; }
    public virtual object activity_id { get; set; }
    public virtual string activity_type { get; set; }
    public virtual string trigger_type { get; set; }
    public virtual string state { get; set; }
    public virtual string schedule_date { get; set; }
    public virtual string state_msg { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] child_ids { get; set; }
    public virtual long[] mailing_trace_ids { get; set; }
    public virtual string mailing_trace_status { get; set; }
    public virtual string links_click_datetime { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}