namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Pos_preparation_displayOrder
{
    public virtual bool displayed { get; set; }
    public virtual object pos_order_id { get; set; }
    public virtual object pos_config_id { get; set; }
    public virtual long[] order_stage_ids { get; set; }
    public virtual long[] preparation_display_order_line_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object pos_table_id { get; set; }
    public virtual string pos_table_stand_number { get; set; }
    public virtual bool pos_takeaway { get; set; }
}