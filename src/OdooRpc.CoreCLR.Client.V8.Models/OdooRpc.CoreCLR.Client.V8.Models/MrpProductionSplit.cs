namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpProductionSplit
{
    public virtual object production_split_multi_id { get; set; }
    public virtual object production_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual double product_qty { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual double production_capacity { get; set; }
    public virtual long counter { get; set; }
    public virtual long[] production_detailed_vals_ids { get; set; }
    public virtual bool valid_details { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}