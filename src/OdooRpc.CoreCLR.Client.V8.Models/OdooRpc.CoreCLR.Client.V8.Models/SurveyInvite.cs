namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SurveyInvite
{
    public virtual string lang { get; set; }
    public virtual string render_model { get; set; }
    public virtual string subject { get; set; }
    public virtual string body { get; set; }
    public virtual bool body_has_template_value { get; set; }
    public virtual object template_id { get; set; }
    public virtual bool is_mail_template_editor { get; set; }
    public virtual bool can_edit_body { get; set; }
    public virtual long[] attachment_ids { get; set; }
    public virtual object author_id { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual long[] existing_partner_ids { get; set; }
    public virtual string emails { get; set; }
    public virtual string existing_emails { get; set; }
    public virtual string existing_mode { get; set; }
    public virtual string existing_text { get; set; }
    public virtual object mail_server_id { get; set; }
    public virtual object survey_id { get; set; }
    public virtual string survey_start_url { get; set; }
    public virtual string survey_access_mode { get; set; }
    public virtual bool survey_users_login_required { get; set; }
    public virtual bool survey_users_can_signup { get; set; }
    public virtual string deadline { get; set; }
    public virtual bool send_email { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}