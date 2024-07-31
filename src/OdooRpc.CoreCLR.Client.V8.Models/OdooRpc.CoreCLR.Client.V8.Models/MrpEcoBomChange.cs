namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpEcoBomChange
{
    public virtual object eco_id { get; set; }
    public virtual object eco_rebase_id { get; set; }
    public virtual object rebase_id { get; set; }
    public virtual string change_type { get; set; }
    public virtual object product_id { get; set; }
    public virtual object old_uom_id { get; set; }
    public virtual object new_uom_id { get; set; }
    public virtual double old_product_qty { get; set; }
    public virtual double new_product_qty { get; set; }
    public virtual object old_operation_id { get; set; }
    public virtual object new_operation_id { get; set; }
    public virtual double upd_product_qty { get; set; }
    public virtual string uom_change { get; set; }
    public virtual string operation_change { get; set; }
    public virtual bool conflict { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}