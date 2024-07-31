namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PaymentToken
{
    public virtual object provider_id { get; set; }
    public virtual string provider_code { get; set; }
    public virtual object company_id { get; set; }
    public virtual object payment_method_id { get; set; }
    public virtual string payment_method_code { get; set; }
    public virtual string payment_details { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string provider_ref { get; set; }
    public virtual long[] transaction_ids { get; set; }
    public virtual bool active { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}