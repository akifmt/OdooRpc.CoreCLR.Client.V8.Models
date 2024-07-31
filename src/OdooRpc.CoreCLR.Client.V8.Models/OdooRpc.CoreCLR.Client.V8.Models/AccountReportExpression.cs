namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountReportExpression
{
    public virtual object report_line_id { get; set; }
    public virtual string report_line_name { get; set; }
    public virtual string label { get; set; }
    public virtual string engine { get; set; }
    public virtual string formula { get; set; }
    public virtual string subformula { get; set; }
    public virtual string date_scope { get; set; }
    public virtual string figure_type { get; set; }
    public virtual bool green_on_positive { get; set; }
    public virtual bool blank_if_zero { get; set; }
    public virtual bool auditable { get; set; }
    public virtual string carryover_target { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}