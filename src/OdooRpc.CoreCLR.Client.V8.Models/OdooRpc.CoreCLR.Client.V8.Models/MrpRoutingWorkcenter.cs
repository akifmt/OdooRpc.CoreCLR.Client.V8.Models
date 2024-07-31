namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpRoutingWorkcenter
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual object workcenter_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual object bom_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string worksheet_type { get; set; }
    public virtual string note { get; set; }
    public virtual string worksheet { get; set; }
    public virtual string worksheet_google_slide { get; set; }
    public virtual string time_mode { get; set; }
    public virtual long time_mode_batch { get; set; }
    public virtual string time_computed_on { get; set; }
    public virtual double time_cycle_manual { get; set; }
    public virtual double time_cycle { get; set; }
    public virtual long workorder_count { get; set; }
    public virtual long[] workorder_ids { get; set; }
    public virtual long[] possible_bom_product_template_attribute_value_ids { get; set; }
    public virtual long[] bom_product_template_attribute_value_ids { get; set; }
    public virtual bool allow_operation_dependencies { get; set; }
    public virtual long[] blocked_by_operation_ids { get; set; }
    public virtual long[] needed_by_operation_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] quality_point_ids { get; set; }
    public virtual long quality_point_count { get; set; }
    public virtual double employee_ratio { get; set; }
}