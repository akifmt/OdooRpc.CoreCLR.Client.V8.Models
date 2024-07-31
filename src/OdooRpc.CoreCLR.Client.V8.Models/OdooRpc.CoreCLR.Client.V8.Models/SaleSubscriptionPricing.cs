namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleSubscriptionPricing
{
    public virtual bool active { get; set; }
    public virtual string name { get; set; }
    public virtual object product_template_id { get; set; }
    public virtual long[] product_variant_ids { get; set; }
    public virtual object plan_id { get; set; }
    public virtual object pricelist_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string price { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}