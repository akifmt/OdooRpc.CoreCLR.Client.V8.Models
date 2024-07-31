namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailComposeMessage
{
    public virtual string lang { get; set; }
    public virtual string render_model { get; set; }
    public virtual string subject { get; set; }
    public virtual string body { get; set; }
    public virtual bool body_has_template_value { get; set; }
    public virtual object template_id { get; set; }
    public virtual bool is_mail_template_editor { get; set; }
    public virtual bool can_edit_body { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] attachment_ids { get; set; }
    public virtual string email_layout_xmlid { get; set; }
    public virtual bool email_add_signature { get; set; }
    public virtual string email_from { get; set; }
    public virtual object author_id { get; set; }
    public virtual string composition_mode { get; set; }
    public virtual bool composition_batch { get; set; }
    public virtual string model { get; set; }
    public virtual bool model_is_thread { get; set; }
    public virtual string res_ids { get; set; }
    public virtual string res_domain { get; set; }
    public virtual object res_domain_user_id { get; set; }
    public virtual object record_alias_domain_id { get; set; }
    public virtual object record_company_id { get; set; }
    public virtual string record_name { get; set; }
    public virtual string message_type { get; set; }
    public virtual object subtype_id { get; set; }
    public virtual bool subtype_is_log { get; set; }
    public virtual object mail_activity_type_id { get; set; }
    public virtual string reply_to { get; set; }
    public virtual bool reply_to_force_new { get; set; }
    public virtual string reply_to_mode { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual bool auto_delete { get; set; }
    public virtual bool auto_delete_keep_log { get; set; }
    public virtual bool force_send { get; set; }
    public virtual object mail_server_id { get; set; }
    public virtual string scheduled_date { get; set; }
    public virtual bool use_exclusion_list { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}