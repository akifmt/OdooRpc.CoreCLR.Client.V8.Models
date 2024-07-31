namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountReconcileWizard
{
    public virtual object company_id { get; set; }
    public virtual long[] move_line_ids { get; set; }
    public virtual object reco_account_id { get; set; }
    public virtual string amount { get; set; }
    public virtual object company_currency_id { get; set; }
    public virtual string amount_currency { get; set; }
    public virtual object reco_currency_id { get; set; }
    public virtual string edit_mode_amount { get; set; }
    public virtual string edit_mode_amount_currency { get; set; }
    public virtual object edit_mode_reco_currency_id { get; set; }
    public virtual bool edit_mode { get; set; }
    public virtual bool single_currency_mode { get; set; }
    public virtual bool allow_partials { get; set; }
    public virtual bool force_partials { get; set; }
    public virtual bool display_allow_partials { get; set; }
    public virtual string date { get; set; }
    public virtual object journal_id { get; set; }
    public virtual object account_id { get; set; }
    public virtual bool is_rec_pay_account { get; set; }
    public virtual object to_partner_id { get; set; }
    public virtual string label { get; set; }
    public virtual object tax_id { get; set; }
    public virtual bool to_check { get; set; }
    public virtual bool is_write_off_required { get; set; }
    public virtual bool is_transfer_required { get; set; }
    public virtual string transfer_warning_message { get; set; }
    public virtual object transfer_from_account_id { get; set; }
    public virtual string lock_date_violated_warning_message { get; set; }
    public virtual object reco_model_id { get; set; }
    public virtual long[] reco_model_autocomplete_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}