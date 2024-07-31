namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountReconcileModelLine
{
    public virtual string analytic_distribution { get; set; }
    public virtual long analytic_precision { get; set; }
    public virtual object model_id { get; set; }
    public virtual bool allow_payment_tolerance { get; set; }
    public virtual double payment_tolerance_param { get; set; }
    public virtual string rule_type { get; set; }
    public virtual object company_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual object account_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual string label { get; set; }
    public virtual string amount_type { get; set; }
    public virtual bool show_force_tax_included { get; set; }
    public virtual bool force_tax_included { get; set; }
    public virtual double amount { get; set; }
    public virtual string amount_string { get; set; }
    public virtual long[] tax_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}