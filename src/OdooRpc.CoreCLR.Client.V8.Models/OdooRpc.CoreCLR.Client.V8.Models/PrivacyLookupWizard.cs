namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PrivacyLookupWizard
{
    public virtual string name { get; set; }
    public virtual string email { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual string execution_details { get; set; }
    public virtual object log_id { get; set; }
    public virtual string records_description { get; set; }
    public virtual long line_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}