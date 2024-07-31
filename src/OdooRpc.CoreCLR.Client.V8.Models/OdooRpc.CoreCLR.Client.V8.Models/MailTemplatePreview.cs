namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailTemplatePreview
{
    public virtual object mail_template_id { get; set; }
    public virtual object model_id { get; set; }
    public virtual string resource_ref { get; set; }
    public virtual string lang { get; set; }
    public virtual bool no_record { get; set; }
    public virtual string error_msg { get; set; }
    public virtual string subject { get; set; }
    public virtual string email_from { get; set; }
    public virtual string email_to { get; set; }
    public virtual string email_cc { get; set; }
    public virtual string reply_to { get; set; }
    public virtual string scheduled_date { get; set; }
    public virtual string body_html { get; set; }
    public virtual long[] attachment_ids { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}