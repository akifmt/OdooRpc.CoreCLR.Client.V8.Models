namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountRoot
{
    public virtual string name { get; set; }
    public virtual object parent_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}