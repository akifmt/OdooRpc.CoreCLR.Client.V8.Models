namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ReportStockQuantity
{
    public virtual string date { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual string state { get; set; }
    public virtual double product_qty { get; set; }
    public virtual object company_id { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}