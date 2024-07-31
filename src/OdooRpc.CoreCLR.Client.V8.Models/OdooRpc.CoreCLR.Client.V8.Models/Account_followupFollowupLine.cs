namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Account_followupFollowupLine
{
    public virtual string name { get; set; }
    public virtual long delay { get; set; }
    public virtual object company_id { get; set; }
    public virtual object mail_template_id { get; set; }
    public virtual bool send_email { get; set; }
    public virtual bool join_invoices { get; set; }
    public virtual long[] additional_follower_ids { get; set; }
    public virtual object sms_template_id { get; set; }
    public virtual bool send_sms { get; set; }
    public virtual bool create_activity { get; set; }
    public virtual string activity_summary { get; set; }
    public virtual string activity_note { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_default_responsible_type { get; set; }
    public virtual bool auto_execute { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool send_letter { get; set; }
}