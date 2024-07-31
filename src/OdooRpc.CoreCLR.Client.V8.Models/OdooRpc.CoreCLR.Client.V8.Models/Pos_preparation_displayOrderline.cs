namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Pos_preparation_displayOrderline
{
    public virtual bool todo { get; set; }
    public virtual string internal_note { get; set; }
    public virtual long[] attribute_value_ids { get; set; }
    public virtual object product_id { get; set; }
    public virtual long product_quantity { get; set; }
    public virtual long product_cancelled { get; set; }
    public virtual object preparation_display_order_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}