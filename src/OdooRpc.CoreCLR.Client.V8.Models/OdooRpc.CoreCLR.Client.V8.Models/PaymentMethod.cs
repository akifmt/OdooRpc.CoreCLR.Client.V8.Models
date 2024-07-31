namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PaymentMethod
{
    public virtual string name { get; set; }
    public virtual string code { get; set; }
    public virtual long sequence { get; set; }
    public virtual object primary_payment_method_id { get; set; }
    public virtual long[] brand_ids { get; set; }
    public virtual bool is_primary { get; set; }
    public virtual long[] provider_ids { get; set; }
    public virtual bool active { get; set; }
    public virtual string image { get; set; }
    public virtual string image_payment_form { get; set; }
    public virtual bool support_tokenization { get; set; }
    public virtual bool support_express_checkout { get; set; }
    public virtual string support_refund { get; set; }
    public virtual long[] supported_country_ids { get; set; }
    public virtual long[] supported_currency_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}