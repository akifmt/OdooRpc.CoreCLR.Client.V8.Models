namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockPickingType
{
    public virtual string name { get; set; }
    public virtual long color { get; set; }
    public virtual long sequence { get; set; }
    public virtual object sequence_id { get; set; }
    public virtual string sequence_code { get; set; }
    public virtual object default_location_src_id { get; set; }
    public virtual object default_location_dest_id { get; set; }
    public virtual object default_location_return_id { get; set; }
    public virtual string code { get; set; }
    public virtual object return_picking_type_id { get; set; }
    public virtual bool show_entire_packs { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual bool active { get; set; }
    public virtual bool use_create_lots { get; set; }
    public virtual bool use_existing_lots { get; set; }
    public virtual bool print_label { get; set; }
    public virtual bool show_operations { get; set; }
    public virtual string reservation_method { get; set; }
    public virtual long reservation_days_before { get; set; }
    public virtual long reservation_days_before_priority { get; set; }
    public virtual bool auto_show_reception_report { get; set; }
    public virtual bool auto_print_delivery_slip { get; set; }
    public virtual bool auto_print_return_slip { get; set; }
    public virtual bool auto_print_product_labels { get; set; }
    public virtual string product_label_format { get; set; }
    public virtual bool auto_print_lot_labels { get; set; }
    public virtual string lot_label_format { get; set; }
    public virtual bool auto_print_reception_report { get; set; }
    public virtual bool auto_print_reception_report_labels { get; set; }
    public virtual bool auto_print_packages { get; set; }
    public virtual bool auto_print_package_label { get; set; }
    public virtual string package_label_to_print { get; set; }
    public virtual long count_picking_draft { get; set; }
    public virtual long count_picking_ready { get; set; }
    public virtual long count_picking { get; set; }
    public virtual long count_picking_waiting { get; set; }
    public virtual long count_picking_late { get; set; }
    public virtual long count_picking_backorders { get; set; }
    public virtual bool hide_reservation_method { get; set; }
    public virtual string barcode { get; set; }
    public virtual object company_id { get; set; }
    public virtual string create_backorder { get; set; }
    public virtual bool show_picking_type { get; set; }
    public virtual string picking_properties_definition { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}