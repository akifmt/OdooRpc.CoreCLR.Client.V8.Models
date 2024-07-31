namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SmsResendRecipient
{
    public virtual object sms_resend_id { get; set; }
    public virtual object notification_id { get; set; }
    public virtual bool resend { get; set; }
    public virtual string failure_type { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string partner_name { get; set; }
    public virtual string sms_number { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}