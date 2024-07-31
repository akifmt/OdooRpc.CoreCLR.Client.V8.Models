namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountReportExternalValue
{
    public virtual string name { get; set; }
    public virtual double value { get; set; }
    public virtual string text_value { get; set; }
    public virtual string date { get; set; }
    public virtual object target_report_expression_id { get; set; }
    public virtual object target_report_line_id { get; set; }
    public virtual string target_report_expression_label { get; set; }
    public virtual object report_country_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object foreign_vat_fiscal_position_id { get; set; }
    public virtual string carryover_origin_expression_label { get; set; }
    public virtual object carryover_origin_report_line_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}