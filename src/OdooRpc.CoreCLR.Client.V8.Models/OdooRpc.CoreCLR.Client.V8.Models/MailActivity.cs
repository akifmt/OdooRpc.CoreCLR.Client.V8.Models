namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailActivity
{
    public virtual object res_model_id { get; set; }
    public virtual string res_model { get; set; }
    public virtual string res_id { get; set; }
    public virtual string res_name { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_category { get; set; }
    public virtual string activity_decoration { get; set; }
    public virtual string icon { get; set; }
    public virtual string summary { get; set; }
    public virtual string note { get; set; }
    public virtual string date_deadline { get; set; }
    public virtual string date_done { get; set; }
    public virtual bool automated { get; set; }
    public virtual long[] attachment_ids { get; set; }
    public virtual object user_id { get; set; }
    public virtual object request_partner_id { get; set; }
    public virtual string state { get; set; }
    public virtual object recommended_activity_type_id { get; set; }
    public virtual object previous_activity_type_id { get; set; }
    public virtual bool has_recommended_activities { get; set; }
    public virtual long[] mail_template_ids { get; set; }
    public virtual string chaining_type { get; set; }
    public virtual bool can_write { get; set; }
    public virtual bool active { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object calendar_event_id { get; set; }
}