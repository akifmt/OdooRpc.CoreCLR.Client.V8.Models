namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class RentalOrderWizardLine
{
    public virtual object rental_order_wizard_id { get; set; }
    public virtual string status { get; set; }
    public virtual object order_line_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual double qty_reserved { get; set; }
    public virtual double qty_delivered { get; set; }
    public virtual double qty_returned { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual double qty_available { get; set; }
    public virtual bool is_product_storable { get; set; }
    public virtual string tracking { get; set; }
    public virtual long[] pickeable_lot_ids { get; set; }
    public virtual long[] returnable_lot_ids { get; set; }
    public virtual long[] pickedup_lot_ids { get; set; }
    public virtual long[] returned_lot_ids { get; set; }
}