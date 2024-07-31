namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SmsSms
{
    public virtual string uuid { get; set; }
    public virtual string number { get; set; }
    public virtual string body { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object mail_message_id { get; set; }
    public virtual string state { get; set; }
    public virtual string failure_type { get; set; }
    public virtual object sms_tracker_id { get; set; }
    public virtual bool to_delete { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}