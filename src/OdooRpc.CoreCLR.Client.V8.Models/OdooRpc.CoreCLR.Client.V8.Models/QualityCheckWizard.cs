namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class QualityCheckWizard
{
    public virtual long[] check_ids { get; set; }
    public virtual object current_check_id { get; set; }
    public virtual long nb_checks { get; set; }
    public virtual long position_current_check { get; set; }
    public virtual bool is_last_check { get; set; }
    public virtual object failure_location_id { get; set; }
    public virtual double qty_failed { get; set; }
    public virtual long[] potential_failure_location_ids { get; set; }
    public virtual string name { get; set; }
    public virtual string title { get; set; }
    public virtual object product_id { get; set; }
    public virtual string lot_name { get; set; }
    public virtual object lot_line_id { get; set; }
    public virtual double qty_line { get; set; }
    public virtual double qty_to_test { get; set; }
    public virtual double qty_tested { get; set; }
    public virtual double measure { get; set; }
    public virtual string measure_on { get; set; }
    public virtual string quality_state { get; set; }
    public virtual string test_type { get; set; }
    public virtual string norm_unit { get; set; }
    public virtual string picture { get; set; }
    public virtual string note { get; set; }
    public virtual string additional_note { get; set; }
    public virtual bool is_lot_tested_fractionally { get; set; }
    public virtual double testing_percentage_within_lot { get; set; }
    public virtual object uom_id { get; set; }
    public virtual string warning_message { get; set; }
    public virtual string failure_message { get; set; }
    public virtual bool show_lot_text { get; set; }
    public virtual string product_tracking { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}