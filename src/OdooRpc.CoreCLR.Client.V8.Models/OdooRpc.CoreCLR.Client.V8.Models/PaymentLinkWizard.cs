namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PaymentLinkWizard
{
    public virtual string res_model { get; set; }
    public virtual long res_id { get; set; }
    public virtual string amount { get; set; }
    public virtual string amount_max { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string partner_email { get; set; }
    public virtual string link { get; set; }
    public virtual object company_id { get; set; }
    public virtual string warning_message { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string amount_paid { get; set; }
    public virtual string confirmation_message { get; set; }
}