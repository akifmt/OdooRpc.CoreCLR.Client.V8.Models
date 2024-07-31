namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpConsumptionWarningLine
{
    public virtual object mrp_consumption_warning_id { get; set; }
    public virtual object mrp_production_id { get; set; }
    public virtual string consumption { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual double product_consumed_qty_uom { get; set; }
    public virtual double product_expected_qty_uom { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}