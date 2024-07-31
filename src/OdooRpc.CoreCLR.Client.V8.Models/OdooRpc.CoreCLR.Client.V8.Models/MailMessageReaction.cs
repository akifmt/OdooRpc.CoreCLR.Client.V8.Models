namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailMessageReaction
{
    public virtual object message_id { get; set; }
    public virtual string content { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object guest_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}