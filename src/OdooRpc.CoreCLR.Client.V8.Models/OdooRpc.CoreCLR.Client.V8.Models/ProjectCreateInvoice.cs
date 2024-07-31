namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProjectCreateInvoice
{
    public virtual object project_id { get; set; }
    public virtual long[] _candidate_orders { get; set; }
    public virtual object sale_order_id { get; set; }
    public virtual string amount_to_invoice { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}