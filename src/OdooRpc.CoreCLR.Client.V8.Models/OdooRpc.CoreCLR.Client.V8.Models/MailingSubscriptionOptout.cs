namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailingSubscriptionOptout
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool is_feedback { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}