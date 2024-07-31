namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountBankStatementLineTransient
{
    public virtual long sequence { get; set; }
    public virtual string date { get; set; }
    public virtual string amount { get; set; }
    public virtual string online_transaction_identifier { get; set; }
    public virtual string payment_ref { get; set; }
    public virtual string account_number { get; set; }
    public virtual string partner_name { get; set; }
    public virtual string transaction_details { get; set; }
    public virtual string state { get; set; }
    public virtual object journal_id { get; set; }
    public virtual object online_account_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}