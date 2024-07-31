namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BankRecWidget
{
    public virtual object st_line_id { get; set; }
    public virtual object move_id { get; set; }
    public virtual bool st_line_to_check { get; set; }
    public virtual bool st_line_is_reconciled { get; set; }
    public virtual object st_line_journal_id { get; set; }
    public virtual string st_line_narration { get; set; }
    public virtual string st_line_transaction_details { get; set; }
    public virtual object transaction_currency_id { get; set; }
    public virtual object journal_currency_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual long[] available_reco_model_ids { get; set; }
    public virtual object selected_reco_model_id { get; set; }
    public virtual string partner_name { get; set; }
    public virtual object company_id { get; set; }
    public virtual object company_currency_id { get; set; }
    public virtual bool matching_rules_allow_auto_reconcile { get; set; }
    public virtual string state { get; set; }
    public virtual long[] selected_aml_ids { get; set; }
    public virtual string todo_command { get; set; }
    public virtual string return_todo_command { get; set; }
    public virtual string form_index { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual long[] matched_sale_order_ids { get; set; }
}