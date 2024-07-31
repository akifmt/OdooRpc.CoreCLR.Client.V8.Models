namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailNotification
{
    public virtual object author_id { get; set; }
    public virtual object mail_message_id { get; set; }
    public virtual object mail_mail_id { get; set; }
    public virtual object res_partner_id { get; set; }
    public virtual string notification_type { get; set; }
    public virtual string notification_status { get; set; }
    public virtual bool is_read { get; set; }
    public virtual string read_date { get; set; }
    public virtual string failure_type { get; set; }
    public virtual string failure_reason { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual long sms_id_int { get; set; }
    public virtual object sms_id { get; set; }
    public virtual long[] sms_tracker_ids { get; set; }
    public virtual string sms_number { get; set; }
    public virtual object letter_id { get; set; }
}