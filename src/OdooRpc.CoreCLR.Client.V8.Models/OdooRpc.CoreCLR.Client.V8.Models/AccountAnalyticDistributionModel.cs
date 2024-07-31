namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountAnalyticDistributionModel
{
    public virtual string analytic_distribution { get; set; }
    public virtual long analytic_precision { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object partner_category_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string account_prefix { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_categ_id { get; set; }
}