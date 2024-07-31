using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountMoveLine
{
    public virtual string analytic_distribution { get; set; }
    public virtual long analytic_precision { get; set; }
    public virtual object move_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object company_currency_id { get; set; }
    public virtual string move_name { get; set; }
    public virtual string parent_state { get; set; }
    public virtual string date { get; set; }
    public virtual string invoice_date { get; set; }

    [JsonPropertyName("ref")]
    public virtual string ref_ { get; set; }

    public virtual bool is_storno { get; set; }
    public virtual long sequence { get; set; }
    public virtual string move_type { get; set; }
    public virtual object account_id { get; set; }
    public virtual string name { get; set; }
    public virtual string debit { get; set; }
    public virtual string credit { get; set; }
    public virtual string balance { get; set; }
    public virtual string cumulated_balance { get; set; }
    public virtual double currency_rate { get; set; }
    public virtual string amount_currency { get; set; }
    public virtual object currency_id { get; set; }
    public virtual bool is_same_currency { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object reconcile_model_id { get; set; }
    public virtual object payment_id { get; set; }
    public virtual object statement_line_id { get; set; }
    public virtual object statement_id { get; set; }
    public virtual long[] tax_ids { get; set; }
    public virtual object group_tax_id { get; set; }
    public virtual object tax_line_id { get; set; }
    public virtual object tax_group_id { get; set; }
    public virtual string tax_base_amount { get; set; }
    public virtual object tax_repartition_line_id { get; set; }
    public virtual long[] tax_tag_ids { get; set; }
    public virtual bool tax_tag_invert { get; set; }
    public virtual string amount_residual { get; set; }
    public virtual string amount_residual_currency { get; set; }
    public virtual bool reconciled { get; set; }
    public virtual object full_reconcile_id { get; set; }
    public virtual long[] matched_debit_ids { get; set; }
    public virtual long[] matched_credit_ids { get; set; }
    public virtual string matching_number { get; set; }
    public virtual bool is_account_reconcile { get; set; }
    public virtual string account_type { get; set; }
    public virtual string account_internal_group { get; set; }
    public virtual object account_root_id { get; set; }
    public virtual object product_category_id { get; set; }
    public virtual string display_type { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual double quantity { get; set; }
    public virtual string date_maturity { get; set; }
    public virtual double price_unit { get; set; }
    public virtual string price_subtotal { get; set; }
    public virtual string price_total { get; set; }
    public virtual double discount { get; set; }
    public virtual string tax_calculation_rounding_method { get; set; }
    public virtual string term_key { get; set; }
    public virtual string tax_key { get; set; }
    public virtual string compute_all_tax { get; set; }
    public virtual bool compute_all_tax_dirty { get; set; }
    public virtual string epd_key { get; set; }
    public virtual string epd_needed { get; set; }
    public virtual bool epd_dirty { get; set; }
    public virtual string discount_allocation_key { get; set; }
    public virtual string discount_allocation_needed { get; set; }
    public virtual bool discount_allocation_dirty { get; set; }
    public virtual long[] analytic_line_ids { get; set; }
    public virtual string discount_date { get; set; }
    public virtual string discount_amount_currency { get; set; }
    public virtual string discount_balance { get; set; }
    public virtual string payment_date { get; set; }
    public virtual bool blocked { get; set; }
    public virtual bool is_refund { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool is_downpayment { get; set; }
    public virtual long[] sale_line_ids { get; set; }
}