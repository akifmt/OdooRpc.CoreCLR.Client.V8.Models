namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SlideChannelInvite
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
    public virtual bool send_email { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual object channel_id { get; set; }
    public virtual string channel_invite_url { get; set; }
    public virtual string channel_visibility { get; set; }
    public virtual bool channel_published { get; set; }
    public virtual bool enroll_mode { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}