namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Account_followupManual_reminder
{
    public virtual string lang { get; set; }
    public virtual string render_model { get; set; }
    public virtual string subject { get; set; }
    public virtual string body { get; set; }
    public virtual bool body_has_template_value { get; set; }
    public virtual object template_id { get; set; }
    public virtual bool is_mail_template_editor { get; set; }
    public virtual bool can_edit_body { get; set; }
    public virtual object partner_id { get; set; }
    public virtual bool email { get; set; }
    public virtual long[] email_recipient_ids { get; set; }
    public virtual bool sms { get; set; }
    public virtual string sms_body { get; set; }
    public virtual object sms_template_id { get; set; }
    public virtual bool print { get; set; }
    public virtual bool join_invoices { get; set; }
    public virtual long[] attachment_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool snailmail { get; set; }
    public virtual double snailmail_cost { get; set; }
}