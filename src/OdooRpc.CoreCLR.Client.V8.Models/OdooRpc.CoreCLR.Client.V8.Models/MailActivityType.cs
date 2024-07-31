namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailActivityType
{
    public virtual string name { get; set; }
    public virtual string summary { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool active { get; set; }
    public virtual object create_uid { get; set; }
    public virtual long delay_count { get; set; }
    public virtual string delay_unit { get; set; }
    public virtual string delay_label { get; set; }
    public virtual string delay_from { get; set; }
    public virtual string icon { get; set; }
    public virtual string decoration_type { get; set; }
    public virtual string res_model { get; set; }
    public virtual object triggered_next_type_id { get; set; }
    public virtual string chaining_type { get; set; }
    public virtual long[] suggested_next_type_ids { get; set; }
    public virtual long[] previous_type_ids { get; set; }
    public virtual string category { get; set; }
    public virtual long[] mail_template_ids { get; set; }
    public virtual object default_user_id { get; set; }
    public virtual string default_note { get; set; }
    public virtual bool keep_done { get; set; }
    public virtual string initial_res_model { get; set; }
    public virtual bool res_model_change { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string dashboard_visibility { get; set; }
}