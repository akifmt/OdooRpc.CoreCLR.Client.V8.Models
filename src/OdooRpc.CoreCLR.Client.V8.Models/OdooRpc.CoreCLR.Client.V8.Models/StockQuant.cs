namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockQuant
{
    public virtual object product_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual bool is_favorite { get; set; }
    public virtual object company_id { get; set; }
    public virtual object location_id { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual object storage_category_id { get; set; }
    public virtual long cyclic_inventory_frequency { get; set; }
    public virtual object lot_id { get; set; }
    public virtual object[] lot_properties { get; set; }
    public virtual bool sn_duplicated { get; set; }
    public virtual object package_id { get; set; }
    public virtual object owner_id { get; set; }
    public virtual double quantity { get; set; }
    public virtual double reserved_quantity { get; set; }
    public virtual double available_quantity { get; set; }
    public virtual string in_date { get; set; }
    public virtual string tracking { get; set; }
    public virtual bool on_hand { get; set; }
    public virtual object product_categ_id { get; set; }
    public virtual double inventory_quantity { get; set; }
    public virtual double inventory_quantity_auto_apply { get; set; }
    public virtual double inventory_diff_quantity { get; set; }
    public virtual string inventory_date { get; set; }
    public virtual string last_count_date { get; set; }
    public virtual bool inventory_quantity_set { get; set; }
    public virtual bool is_outdated { get; set; }
    public virtual object user_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string value { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string accounting_date { get; set; }
    public virtual string cost_method { get; set; }
}