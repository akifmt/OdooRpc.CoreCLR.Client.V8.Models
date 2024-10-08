﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleOrderAlert
{
    public virtual object automation_id { get; set; }
    public virtual object action_id { get; set; }
    public virtual object template_id { get; set; }
    public virtual object sms_template_id { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_summary { get; set; }
    public virtual string activity_note { get; set; }
    public virtual long activity_date_deadline_range { get; set; }
    public virtual string activity_date_deadline_range_type { get; set; }
    public virtual object activity_user_id { get; set; }
    public virtual string action { get; set; }
    public virtual string trigger_condition { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long[] subscription_plan_ids { get; set; }
    public virtual long[] customer_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual string mrr_min { get; set; }
    public virtual long[] team_ids { get; set; }
    public virtual string mrr_max { get; set; }
    public virtual long[] product_ids { get; set; }
    public virtual double mrr_change_amount { get; set; }
    public virtual string mrr_change_unit { get; set; }
    public virtual string mrr_change_period { get; set; }
    public virtual long rating_percentage { get; set; }
    public virtual string rating_operator { get; set; }
    public virtual string subscription_state_from { get; set; }
    public virtual string subscription_state { get; set; }
    public virtual string order_state { get; set; }
    public virtual string activity_user { get; set; }
    public virtual long[] activity_user_ids { get; set; }
    public virtual long subscription_count { get; set; }
    public virtual string cron_nextcall { get; set; }
    public virtual string health { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
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
    public virtual bool is_sale_order_alert { get; set; }
}