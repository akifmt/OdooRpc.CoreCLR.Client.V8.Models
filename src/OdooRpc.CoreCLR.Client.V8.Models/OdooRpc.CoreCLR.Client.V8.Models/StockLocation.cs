namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockLocation
{
    public virtual string name { get; set; }
    public virtual string complete_name { get; set; }
    public virtual bool active { get; set; }
    public virtual string usage { get; set; }
    public virtual object location_id { get; set; }
    public virtual long[] child_ids { get; set; }
    public virtual long[] child_internal_location_ids { get; set; }
    public virtual string comment { get; set; }
    public virtual long posx { get; set; }
    public virtual long posy { get; set; }
    public virtual long posz { get; set; }
    public virtual string parent_path { get; set; }
    public virtual object company_id { get; set; }
    public virtual bool scrap_location { get; set; }
    public virtual bool return_location { get; set; }
    public virtual bool replenish_location { get; set; }
    public virtual object removal_strategy_id { get; set; }
    public virtual long[] putaway_rule_ids { get; set; }
    public virtual string barcode { get; set; }
    public virtual long[] quant_ids { get; set; }
    public virtual long cyclic_inventory_frequency { get; set; }
    public virtual string last_inventory_date { get; set; }
    public virtual string next_inventory_date { get; set; }
    public virtual long[] warehouse_view_ids { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual object storage_category_id { get; set; }
    public virtual long[] outgoing_move_line_ids { get; set; }
    public virtual long[] incoming_move_line_ids { get; set; }
    public virtual double net_weight { get; set; }
    public virtual double forecast_weight { get; set; }
    public virtual bool is_empty { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object valuation_in_account_id { get; set; }
    public virtual object valuation_out_account_id { get; set; }
}