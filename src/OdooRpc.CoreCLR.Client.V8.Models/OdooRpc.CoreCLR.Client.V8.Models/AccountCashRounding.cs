namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountCashRounding
{
    public virtual string name { get; set; }
    public virtual double rounding { get; set; }
    public virtual string strategy { get; set; }
    public virtual object profit_account_id { get; set; }
    public virtual object loss_account_id { get; set; }
    public virtual string rounding_method { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}