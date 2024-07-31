namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailResendPartner
{
    public virtual object notification_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string name { get; set; }
    public virtual string email { get; set; }
    public virtual string failure_reason { get; set; }
    public virtual bool resend { get; set; }
    public virtual object resend_wizard_id { get; set; }
    public virtual string message { get; set; }
    public virtual bool partner_readonly { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}