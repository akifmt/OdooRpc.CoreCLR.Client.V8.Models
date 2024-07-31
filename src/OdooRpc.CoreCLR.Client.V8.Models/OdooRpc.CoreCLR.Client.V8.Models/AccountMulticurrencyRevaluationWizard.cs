namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountMulticurrencyRevaluationWizard
{
    public virtual object company_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual string date { get; set; }
    public virtual string reversal_date { get; set; }
    public virtual object expense_provision_account_id { get; set; }
    public virtual object income_provision_account_id { get; set; }
    public virtual string preview_data { get; set; }
    public virtual object show_warning_move_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}