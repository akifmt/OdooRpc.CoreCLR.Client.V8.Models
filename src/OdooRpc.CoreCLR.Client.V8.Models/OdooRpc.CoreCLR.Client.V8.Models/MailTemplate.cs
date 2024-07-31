namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailTemplate
{
    public virtual string template_fs { get; set; }
    public virtual string lang { get; set; }
    public virtual string render_model { get; set; }
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual bool active { get; set; }
    public virtual string template_category { get; set; }
    public virtual object model_id { get; set; }
    public virtual string model { get; set; }
    public virtual string subject { get; set; }
    public virtual string email_from { get; set; }
    public virtual object user_id { get; set; }
    public virtual bool use_default_to { get; set; }
    public virtual string email_to { get; set; }
    public virtual string partner_to { get; set; }
    public virtual string email_cc { get; set; }
    public virtual string reply_to { get; set; }
    public virtual string body_html { get; set; }
    public virtual long[] attachment_ids { get; set; }
    public virtual long[] report_template_ids { get; set; }
    public virtual string email_layout_xmlid { get; set; }
    public virtual object mail_server_id { get; set; }
    public virtual string scheduled_date { get; set; }
    public virtual bool auto_delete { get; set; }
    public virtual object ref_ir_act_window { get; set; }
    public virtual bool can_write { get; set; }
    public virtual bool is_template_editor { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}