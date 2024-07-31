namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpBatchProduce
{
    public virtual object production_id { get; set; }
    public virtual string production_text_help { get; set; }
    public virtual string production_text { get; set; }
    public virtual string lot_name { get; set; }
    public virtual long lot_qty { get; set; }
    public virtual string component_separator { get; set; }
    public virtual string lots_separator { get; set; }
    public virtual string lots_quantity_separator { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}