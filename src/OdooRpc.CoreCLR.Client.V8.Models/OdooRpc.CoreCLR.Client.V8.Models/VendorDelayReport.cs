namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class VendorDelayReport
{
    public virtual object partner_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object category_id { get; set; }
    public virtual string date { get; set; }
    public virtual double qty_total { get; set; }
    public virtual double qty_on_time { get; set; }
    public virtual double on_time_rate { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}