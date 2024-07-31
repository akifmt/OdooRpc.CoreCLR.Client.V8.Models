namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailingTrace
{
    public virtual string trace_type { get; set; }
    public virtual object mail_mail_id { get; set; }
    public virtual long mail_mail_id_int { get; set; }
    public virtual string email { get; set; }
    public virtual string message_id { get; set; }
    public virtual object medium_id { get; set; }
    public virtual object source_id { get; set; }
    public virtual string model { get; set; }
    public virtual string res_id { get; set; }
    public virtual object mass_mailing_id { get; set; }
    public virtual object campaign_id { get; set; }
    public virtual string sent_datetime { get; set; }
    public virtual string open_datetime { get; set; }
    public virtual string reply_datetime { get; set; }
    public virtual string trace_status { get; set; }
    public virtual string failure_type { get; set; }
    public virtual string failure_reason { get; set; }
    public virtual long[] links_click_ids { get; set; }
    public virtual string links_click_datetime { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object marketing_trace_id { get; set; }
    public virtual object sms_id { get; set; }
    public virtual long sms_id_int { get; set; }
    public virtual long[] sms_tracker_ids { get; set; }
    public virtual string sms_number { get; set; }
    public virtual string sms_code { get; set; }
}