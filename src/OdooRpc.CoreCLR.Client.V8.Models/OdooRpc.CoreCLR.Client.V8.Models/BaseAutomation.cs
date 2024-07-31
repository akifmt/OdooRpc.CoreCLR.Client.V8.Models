namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BaseAutomation
{
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual object model_id { get; set; }
    public virtual string model_name { get; set; }
    public virtual bool model_is_mail_thread { get; set; }
    public virtual long[] action_server_ids { get; set; }
    public virtual string url { get; set; }
    public virtual string webhook_uuid { get; set; }
    public virtual string record_getter { get; set; }
    public virtual bool log_webhook_calls { get; set; }
    public virtual bool active { get; set; }
    public virtual string trigger { get; set; }
    public virtual object trg_selection_field_id { get; set; }
    public virtual string trg_field_ref_model_name { get; set; }
    public virtual string trg_field_ref { get; set; }
    public virtual object trg_date_id { get; set; }
    public virtual long trg_date_range { get; set; }
    public virtual string trg_date_range_type { get; set; }
    public virtual object trg_date_calendar_id { get; set; }
    public virtual string filter_pre_domain { get; set; }
    public virtual string filter_domain { get; set; }
    public virtual string last_run { get; set; }
    public virtual long[] on_change_field_ids { get; set; }
    public virtual long[] trigger_field_ids { get; set; }
    public virtual string least_delay_msg { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool is_sale_order_alert { get; set; }
}