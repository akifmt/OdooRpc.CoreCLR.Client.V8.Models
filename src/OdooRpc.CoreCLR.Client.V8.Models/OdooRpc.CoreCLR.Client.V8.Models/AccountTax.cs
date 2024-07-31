namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountTax
{
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
    public virtual string name { get; set; }
    public virtual string name_searchable { get; set; }
    public virtual string type_tax_use { get; set; }
    public virtual string tax_scope { get; set; }
    public virtual string amount_type { get; set; }
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] children_tax_ids { get; set; }
    public virtual long sequence { get; set; }
    public virtual double amount { get; set; }
    public virtual string description { get; set; }
    public virtual string invoice_label { get; set; }
    public virtual bool price_include { get; set; }
    public virtual bool include_base_amount { get; set; }
    public virtual bool is_base_affected { get; set; }
    public virtual bool analytic { get; set; }
    public virtual object tax_group_id { get; set; }
    public virtual bool hide_tax_exigibility { get; set; }
    public virtual string tax_exigibility { get; set; }
    public virtual object cash_basis_transition_account_id { get; set; }
    public virtual long[] invoice_repartition_line_ids { get; set; }
    public virtual long[] refund_repartition_line_ids { get; set; }
    public virtual long[] repartition_line_ids { get; set; }
    public virtual object country_id { get; set; }
    public virtual string country_code { get; set; }
    public virtual bool is_used { get; set; }
    public virtual string repartition_lines_str { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}