namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountOnlineAccount
{
    public virtual string name { get; set; }
    public virtual string online_identifier { get; set; }
    public virtual double balance { get; set; }
    public virtual string account_number { get; set; }
    public virtual string account_data { get; set; }
    public virtual object account_online_link_id { get; set; }
    public virtual long[] journal_ids { get; set; }
    public virtual string last_sync { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string fetching_status { get; set; }
    public virtual bool inverse_balance_sign { get; set; }
    public virtual bool inverse_transaction_sign { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}