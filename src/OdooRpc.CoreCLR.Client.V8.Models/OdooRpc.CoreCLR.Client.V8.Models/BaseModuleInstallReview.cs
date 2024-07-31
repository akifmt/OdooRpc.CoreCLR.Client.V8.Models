namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BaseModuleInstallReview
{
    public virtual object module_id { get; set; }
    public virtual long[] module_ids { get; set; }
    public virtual string modules_description { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}