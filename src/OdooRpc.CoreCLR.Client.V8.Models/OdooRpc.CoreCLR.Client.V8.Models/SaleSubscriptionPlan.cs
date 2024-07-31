namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleSubscriptionPlan
{
    public virtual bool active { get; set; }
    public virtual string name { get; set; }
    public virtual object company_id { get; set; }
    public virtual long billing_period_value { get; set; }
    public virtual string billing_period_unit { get; set; }
    public virtual string billing_period_display { get; set; }
    public virtual string billing_period_display_sentence { get; set; }
    public virtual bool user_closable { get; set; }
    public virtual bool user_extend { get; set; }
    public virtual bool user_quantity { get; set; }
    public virtual long[] related_plan_id { get; set; }
    public virtual long auto_close_limit { get; set; }
    public virtual string auto_close_limit_display { get; set; }
    public virtual object invoice_mail_template_id { get; set; }
    public virtual long[] product_subscription_pricing_ids { get; set; }
    public virtual long active_subs_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}