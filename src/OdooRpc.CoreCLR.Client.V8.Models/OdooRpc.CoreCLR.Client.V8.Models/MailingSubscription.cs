namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailingSubscription
{
    public virtual object contact_id { get; set; }
    public virtual object list_id { get; set; }
    public virtual bool opt_out { get; set; }
    public virtual object opt_out_reason_id { get; set; }
    public virtual string opt_out_datetime { get; set; }
    public virtual long message_bounce { get; set; }
    public virtual bool is_blacklisted { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}