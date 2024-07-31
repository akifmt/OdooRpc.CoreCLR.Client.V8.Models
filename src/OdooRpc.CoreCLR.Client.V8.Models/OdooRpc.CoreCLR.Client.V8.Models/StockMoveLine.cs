namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockMoveLine
{
    public virtual object picking_id { get; set; }
    public virtual object move_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual string product_category_name { get; set; }
    public virtual double quantity { get; set; }
    public virtual double quantity_product_uom { get; set; }
    public virtual bool picked { get; set; }
    public virtual object package_id { get; set; }
    public virtual object package_level_id { get; set; }
    public virtual object lot_id { get; set; }
    public virtual string lot_name { get; set; }
    public virtual object result_package_id { get; set; }
    public virtual string date { get; set; }
    public virtual string scheduled_date { get; set; }
    public virtual object owner_id { get; set; }
    public virtual object location_id { get; set; }
    public virtual object location_dest_id { get; set; }
    public virtual string location_usage { get; set; }
    public virtual string location_dest_usage { get; set; }
    public virtual bool lots_visible { get; set; }
    public virtual object picking_partner_id { get; set; }
    public virtual string picking_code { get; set; }
    public virtual object picking_type_id { get; set; }
    public virtual bool picking_type_use_create_lots { get; set; }
    public virtual bool picking_type_use_existing_lots { get; set; }
    public virtual bool picking_type_entire_packs { get; set; }
    public virtual string state { get; set; }
    public virtual bool is_inventory { get; set; }
    public virtual bool is_locked { get; set; }
    public virtual long[] consume_line_ids { get; set; }
    public virtual long[] produce_line_ids { get; set; }
    public virtual string reference { get; set; }
    public virtual string tracking { get; set; }
    public virtual string origin { get; set; }
    public virtual string description_picking { get; set; }
    public virtual object quant_id { get; set; }
    public virtual double product_packaging_qty { get; set; }
    public virtual object picking_location_id { get; set; }
    public virtual object picking_location_dest_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}