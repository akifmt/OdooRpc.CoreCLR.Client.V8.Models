namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountReportColumn
{
    public virtual string name { get; set; }
    public virtual string expression_label { get; set; }
    public virtual long sequence { get; set; }
    public virtual object report_id { get; set; }
    public virtual bool sortable { get; set; }
    public virtual string figure_type { get; set; }
    public virtual bool blank_if_zero { get; set; }
    public virtual object custom_audit_action_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}