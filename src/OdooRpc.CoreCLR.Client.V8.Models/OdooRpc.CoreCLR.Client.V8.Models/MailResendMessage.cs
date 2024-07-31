namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailResendMessage
{
    public virtual object mail_message_id { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual long[] notification_ids { get; set; }
    public virtual bool can_cancel { get; set; }
    public virtual bool can_resend { get; set; }
    public virtual bool partner_readonly { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}