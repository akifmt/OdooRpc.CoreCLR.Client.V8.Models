namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountAutomaticEntryWizard
{
    public virtual string action { get; set; }
    public virtual string move_data { get; set; }
    public virtual string preview_move_data { get; set; }
    public virtual long[] move_line_ids { get; set; }
    public virtual string date { get; set; }
    public virtual object company_id { get; set; }
    public virtual object company_currency_id { get; set; }
    public virtual double percentage { get; set; }
    public virtual string total_amount { get; set; }
    public virtual object journal_id { get; set; }
    public virtual string account_type { get; set; }
    public virtual object expense_accrual_account { get; set; }
    public virtual object revenue_accrual_account { get; set; }
    public virtual string lock_date_message { get; set; }
    public virtual object destination_account_id { get; set; }
    public virtual bool display_currency_helper { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}