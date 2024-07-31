namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockReport
{
    public virtual long id { get; set; }
    public virtual string date_done { get; set; }
    public virtual string creation_date { get; set; }
    public virtual string scheduled_date { get; set; }
    public virtual double delay { get; set; }
    public virtual double cycle_time { get; set; }
    public virtual string picking_type_code { get; set; }
    public virtual object operation_type_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual string picking_name { get; set; }
    public virtual string reference { get; set; }
    public virtual object picking_id { get; set; }
    public virtual string state { get; set; }
    public virtual object partner_id { get; set; }
    public virtual bool is_backorder { get; set; }
    public virtual double product_qty { get; set; }
    public virtual bool is_late { get; set; }
    public virtual object company_id { get; set; }
    public virtual object categ_id { get; set; }
    public virtual string display_name { get; set; }
}