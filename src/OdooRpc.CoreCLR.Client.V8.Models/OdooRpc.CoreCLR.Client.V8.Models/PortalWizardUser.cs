namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PortalWizardUser
{
    public virtual object wizard_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string email { get; set; }
    public virtual object user_id { get; set; }
    public virtual string login_date { get; set; }
    public virtual bool is_portal { get; set; }
    public virtual bool is_internal { get; set; }
    public virtual string email_state { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}