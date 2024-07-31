namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockPackage_level
{
    public virtual object package_id { get; set; }
    public virtual object picking_id { get; set; }
    public virtual long[] move_ids { get; set; }
    public virtual long[] move_line_ids { get; set; }
    public virtual object location_id { get; set; }
    public virtual object location_dest_id { get; set; }
    public virtual bool is_done { get; set; }
    public virtual string state { get; set; }
    public virtual bool is_fresh_package { get; set; }
    public virtual string picking_type_code { get; set; }
    public virtual bool show_lots_m2o { get; set; }
    public virtual bool show_lots_text { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}