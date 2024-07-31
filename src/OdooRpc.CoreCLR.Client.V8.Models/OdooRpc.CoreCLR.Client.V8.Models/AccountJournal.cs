using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountJournal
{
    public virtual long[] activity_ids { get; set; }
    public virtual string activity_state { get; set; }
    public virtual object activity_user_id { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_type_icon { get; set; }
    public virtual string activity_date_deadline { get; set; }
    public virtual string my_activity_date_deadline { get; set; }
    public virtual string activity_summary { get; set; }
    public virtual string activity_exception_decoration { get; set; }
    public virtual string activity_exception_icon { get; set; }
    public virtual object activity_calendar_event_id { get; set; }
    public virtual bool message_is_follower { get; set; }
    public virtual long[] message_follower_ids { get; set; }
    public virtual long[] message_partner_ids { get; set; }
    public virtual long[] message_ids { get; set; }
    public virtual bool has_message { get; set; }
    public virtual bool message_needaction { get; set; }
    public virtual long message_needaction_counter { get; set; }
    public virtual bool message_has_error { get; set; }
    public virtual long message_has_error_counter { get; set; }
    public virtual long message_attachment_count { get; set; }
    public virtual long[] rating_ids { get; set; }
    public virtual long[] website_message_ids { get; set; }
    public virtual bool message_has_sms_error { get; set; }
    public virtual object alias_id { get; set; }
    public virtual string alias_name { get; set; }
    public virtual object alias_domain_id { get; set; }
    public virtual string alias_domain { get; set; }
    public virtual string alias_defaults { get; set; }
    public virtual string alias_email { get; set; }
    public virtual string access_url { get; set; }
    public virtual string access_token { get; set; }
    public virtual string access_warning { get; set; }
    public virtual string name { get; set; }
    public virtual string code { get; set; }
    public virtual bool active { get; set; }

    [JsonPropertyName("type")]
    public virtual string type_ { get; set; }

    public virtual long[] account_control_ids { get; set; }
    public virtual string default_account_type { get; set; }
    public virtual object default_account_id { get; set; }
    public virtual object suspense_account_id { get; set; }
    public virtual bool restrict_mode_hash_table { get; set; }
    public virtual long sequence { get; set; }
    public virtual string invoice_reference_type { get; set; }
    public virtual string invoice_reference_model { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string country_code { get; set; }
    public virtual bool refund_sequence { get; set; }
    public virtual bool payment_sequence { get; set; }
    public virtual string sequence_override_regex { get; set; }
    public virtual long[] inbound_payment_method_line_ids { get; set; }
    public virtual long[] outbound_payment_method_line_ids { get; set; }
    public virtual object profit_account_id { get; set; }
    public virtual object loss_account_id { get; set; }
    public virtual object company_partner_id { get; set; }
    public virtual object bank_account_id { get; set; }
    public virtual string bank_statements_source { get; set; }
    public virtual string bank_acc_number { get; set; }
    public virtual object bank_id { get; set; }
    public virtual long[] journal_group_ids { get; set; }
    public virtual object secure_sequence_id { get; set; }
    public virtual long[] available_payment_method_ids { get; set; }
    public virtual string selected_payment_method_codes { get; set; }
    public virtual string accounting_date { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string kanban_dashboard { get; set; }
    public virtual string kanban_dashboard_graph { get; set; }
    public virtual string json_activity_data { get; set; }
    public virtual bool show_on_dashboard { get; set; }
    public virtual long color { get; set; }
    public virtual string current_statement_balance { get; set; }
    public virtual bool has_statement_lines { get; set; }
    public virtual long entries_count { get; set; }
    public virtual bool has_sequence_holes { get; set; }
    public virtual bool has_unhashed_entries { get; set; }
    public virtual object last_statement_id { get; set; }
}