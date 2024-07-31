namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockRule
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual string group_propagation_option { get; set; }
    public virtual object group_id { get; set; }
    public virtual string action { get; set; }
    public virtual long sequence { get; set; }
    public virtual object company_id { get; set; }
    public virtual object location_dest_id { get; set; }
    public virtual object location_src_id { get; set; }
    public virtual bool location_dest_from_rule { get; set; }
    public virtual object route_id { get; set; }
    public virtual object route_company_id { get; set; }
    public virtual string procure_method { get; set; }
    public virtual long route_sequence { get; set; }
    public virtual object picking_type_id { get; set; }
    public virtual string picking_type_code_domain { get; set; }
    public virtual long delay { get; set; }
    public virtual object partner_address_id { get; set; }
    public virtual bool propagate_cancel { get; set; }
    public virtual bool propagate_carrier { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual object propagate_warehouse_id { get; set; }
    public virtual string auto { get; set; }
    public virtual string rule_message { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}