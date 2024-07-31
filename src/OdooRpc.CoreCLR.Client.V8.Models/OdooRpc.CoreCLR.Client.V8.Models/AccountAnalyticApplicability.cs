namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountAnalyticApplicability
{
    public virtual object analytic_plan_id { get; set; }
    public virtual string business_domain { get; set; }
    public virtual string applicability { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string account_prefix { get; set; }
    public virtual object product_categ_id { get; set; }
    public virtual bool display_account_prefix { get; set; }
}