namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class RequestAppraisal
{
    public virtual string lang { get; set; }
    public virtual string render_model { get; set; }
    public virtual string subject { get; set; }
    public virtual string body { get; set; }
    public virtual bool body_has_template_value { get; set; }
    public virtual object template_id { get; set; }
    public virtual bool is_mail_template_editor { get; set; }
    public virtual bool can_edit_body { get; set; }
    public virtual object appraisal_id { get; set; }
    public virtual string user_body { get; set; }
    public virtual object author_id { get; set; }
    public virtual object employee_id { get; set; }
    public virtual long[] recipient_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}