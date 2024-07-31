namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BankRecWidgetLine
{
    public virtual string analytic_distribution { get; set; }
    public virtual long analytic_precision { get; set; }
    public virtual object wizard_id { get; set; }
    public virtual string index { get; set; }
    public virtual string flag { get; set; }
    public virtual object journal_default_account_id { get; set; }
    public virtual object account_id { get; set; }
    public virtual string date { get; set; }
    public virtual string name { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object company_currency_id { get; set; }
    public virtual string amount_currency { get; set; }
    public virtual string balance { get; set; }
    public virtual string debit { get; set; }
    public virtual string credit { get; set; }
    public virtual bool force_price_included_taxes { get; set; }
    public virtual string tax_base_amount_currency { get; set; }
    public virtual object source_aml_id { get; set; }
    public virtual object source_aml_move_id { get; set; }
    public virtual string source_aml_move_name { get; set; }
    public virtual object tax_repartition_line_id { get; set; }
    public virtual long[] tax_ids { get; set; }
    public virtual long[] tax_tag_ids { get; set; }
    public virtual object group_tax_id { get; set; }
    public virtual object reconcile_model_id { get; set; }
    public virtual string source_amount_currency { get; set; }
    public virtual string source_balance { get; set; }
    public virtual string source_debit { get; set; }
    public virtual string source_credit { get; set; }
    public virtual bool display_stroked_amount_currency { get; set; }
    public virtual bool display_stroked_balance { get; set; }
    public virtual object partner_currency_id { get; set; }
    public virtual object partner_receivable_account_id { get; set; }
    public virtual object partner_payable_account_id { get; set; }
    public virtual string partner_receivable_amount { get; set; }
    public virtual string partner_payable_amount { get; set; }
    public virtual string bank_account { get; set; }
    public virtual string suggestion_html { get; set; }
    public virtual string suggestion_amount_currency { get; set; }
    public virtual string suggestion_balance { get; set; }
    public virtual bool manually_modified { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}