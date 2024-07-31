namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountPaymentMethodLine
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual object payment_method_id { get; set; }
    public virtual object payment_account_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual string code { get; set; }
    public virtual string payment_type { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] available_payment_method_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object payment_provider_id { get; set; }
    public virtual string payment_provider_state { get; set; }
}