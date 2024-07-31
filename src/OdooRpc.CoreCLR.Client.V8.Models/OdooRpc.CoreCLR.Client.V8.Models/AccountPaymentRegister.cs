namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountPaymentRegister
{
    public virtual string payment_date { get; set; }
    public virtual string amount { get; set; }
    public virtual bool hide_writeoff_section { get; set; }
    public virtual string communication { get; set; }
    public virtual bool group_payment { get; set; }
    public virtual bool early_payment_discount_mode { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual long[] available_journal_ids { get; set; }
    public virtual long[] available_partner_bank_ids { get; set; }
    public virtual object partner_bank_id { get; set; }
    public virtual object company_currency_id { get; set; }
    public virtual string qr_code { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual string payment_type { get; set; }
    public virtual string partner_type { get; set; }
    public virtual string source_amount { get; set; }
    public virtual string source_amount_currency { get; set; }
    public virtual object source_currency_id { get; set; }
    public virtual bool can_edit_wizard { get; set; }
    public virtual bool can_group_payments { get; set; }
    public virtual object company_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object payment_method_line_id { get; set; }
    public virtual long[] available_payment_method_line_ids { get; set; }
    public virtual string payment_difference { get; set; }
    public virtual string payment_difference_handling { get; set; }
    public virtual object writeoff_account_id { get; set; }
    public virtual string writeoff_label { get; set; }
    public virtual bool writeoff_is_exchange_account { get; set; }
    public virtual bool show_partner_bank_account { get; set; }
    public virtual bool require_partner_bank_account { get; set; }
    public virtual string country_code { get; set; }
    public virtual long[] untrusted_bank_ids { get; set; }
    public virtual long total_payments_amount { get; set; }
    public virtual long untrusted_payments_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object payment_token_id { get; set; }
    public virtual long[] suitable_payment_token_ids { get; set; }
    public virtual bool use_electronic_payment_method { get; set; }
    public virtual string payment_method_code { get; set; }
}