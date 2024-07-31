namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountTaxGroup
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual object company_id { get; set; }
    public virtual object tax_payable_account_id { get; set; }
    public virtual object tax_receivable_account_id { get; set; }
    public virtual object advance_tax_payment_account_id { get; set; }
    public virtual object country_id { get; set; }
    public virtual string country_code { get; set; }
    public virtual string preceding_subtotal { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}