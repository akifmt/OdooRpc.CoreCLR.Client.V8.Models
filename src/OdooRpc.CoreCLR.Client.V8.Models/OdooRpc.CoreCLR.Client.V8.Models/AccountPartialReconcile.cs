namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountPartialReconcile
{
    public virtual object debit_move_id { get; set; }
    public virtual object credit_move_id { get; set; }
    public virtual object full_reconcile_id { get; set; }
    public virtual object exchange_move_id { get; set; }
    public virtual object company_currency_id { get; set; }
    public virtual object debit_currency_id { get; set; }
    public virtual object credit_currency_id { get; set; }
    public virtual string amount { get; set; }
    public virtual string debit_amount_currency { get; set; }
    public virtual string credit_amount_currency { get; set; }
    public virtual object company_id { get; set; }
    public virtual string max_date { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}