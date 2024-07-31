namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrExpenseSplit
{
    public virtual string analytic_distribution { get; set; }
    public virtual long analytic_precision { get; set; }
    public virtual string name { get; set; }
    public virtual object wizard_id { get; set; }
    public virtual object expense_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual long[] tax_ids { get; set; }
    public virtual string total_amount_currency { get; set; }
    public virtual string tax_amount_currency { get; set; }
    public virtual object employee_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual bool product_has_tax { get; set; }
    public virtual bool product_has_cost { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}