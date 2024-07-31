namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PrivacyLookupWizardLine
{
    public virtual object wizard_id { get; set; }
    public virtual long res_id { get; set; }
    public virtual string res_name { get; set; }
    public virtual object res_model_id { get; set; }
    public virtual string res_model { get; set; }
    public virtual string resource_ref { get; set; }
    public virtual bool has_active { get; set; }
    public virtual bool is_active { get; set; }
    public virtual bool is_unlinked { get; set; }
    public virtual string execution_details { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}