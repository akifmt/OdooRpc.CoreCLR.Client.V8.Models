namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResourceMixin
{
    public virtual object resource_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object resource_calendar_id { get; set; }
    public virtual string tz { get; set; }
}