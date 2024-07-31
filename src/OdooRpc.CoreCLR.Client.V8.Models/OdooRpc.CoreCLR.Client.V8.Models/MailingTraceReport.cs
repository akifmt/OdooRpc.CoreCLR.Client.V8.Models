namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailingTraceReport
{
    public virtual string name { get; set; }
    public virtual string mailing_type { get; set; }
    public virtual string campaign { get; set; }
    public virtual string scheduled_date { get; set; }
    public virtual string state { get; set; }
    public virtual string email_from { get; set; }
    public virtual long scheduled { get; set; }
    public virtual long processing { get; set; }
    public virtual long pending { get; set; }
    public virtual long sent { get; set; }
    public virtual long delivered { get; set; }
    public virtual long error { get; set; }
    public virtual long opened { get; set; }
    public virtual long replied { get; set; }
    public virtual long bounced { get; set; }
    public virtual long canceled { get; set; }
    public virtual long clicked { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}