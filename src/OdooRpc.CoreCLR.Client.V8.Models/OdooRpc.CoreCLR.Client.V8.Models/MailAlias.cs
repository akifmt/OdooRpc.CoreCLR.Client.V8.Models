namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailAlias
{
    public virtual string alias_name { get; set; }
    public virtual string alias_full_name { get; set; }
    public virtual string display_name { get; set; }
    public virtual object alias_domain_id { get; set; }
    public virtual string alias_domain { get; set; }
    public virtual object alias_model_id { get; set; }
    public virtual string alias_defaults { get; set; }
    public virtual long alias_force_thread_id { get; set; }
    public virtual object alias_parent_model_id { get; set; }
    public virtual long alias_parent_thread_id { get; set; }
    public virtual string alias_contact { get; set; }
    public virtual bool alias_incoming_local { get; set; }
    public virtual string alias_bounced_content { get; set; }
    public virtual string alias_status { get; set; }
    public virtual long id { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}