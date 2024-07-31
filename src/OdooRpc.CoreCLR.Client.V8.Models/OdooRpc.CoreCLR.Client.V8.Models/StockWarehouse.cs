namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockWarehouse
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual object company_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object view_location_id { get; set; }
    public virtual object lot_stock_id { get; set; }
    public virtual string code { get; set; }
    public virtual long[] route_ids { get; set; }
    public virtual string reception_steps { get; set; }
    public virtual string delivery_steps { get; set; }
    public virtual object wh_input_stock_loc_id { get; set; }
    public virtual object wh_qc_stock_loc_id { get; set; }
    public virtual object wh_output_stock_loc_id { get; set; }
    public virtual object wh_pack_stock_loc_id { get; set; }
    public virtual object mto_pull_id { get; set; }
    public virtual object pick_type_id { get; set; }
    public virtual object pack_type_id { get; set; }
    public virtual object out_type_id { get; set; }
    public virtual object in_type_id { get; set; }
    public virtual object int_type_id { get; set; }
    public virtual object crossdock_route_id { get; set; }
    public virtual object reception_route_id { get; set; }
    public virtual object delivery_route_id { get; set; }
    public virtual long[] resupply_wh_ids { get; set; }
    public virtual long[] resupply_route_ids { get; set; }
    public virtual long sequence { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object pos_type_id { get; set; }
}