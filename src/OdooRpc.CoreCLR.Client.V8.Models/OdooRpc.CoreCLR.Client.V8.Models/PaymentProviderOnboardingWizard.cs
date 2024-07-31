namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PaymentProviderOnboardingWizard
{
    public virtual string payment_method { get; set; }
    public virtual string paypal_email_account { get; set; }
    public virtual string paypal_pdt_token { get; set; }
    public virtual string manual_name { get; set; }
    public virtual string journal_name { get; set; }
    public virtual string acc_number { get; set; }
    public virtual string manual_post_msg { get; set; }
    public virtual bool _data_fetched { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}