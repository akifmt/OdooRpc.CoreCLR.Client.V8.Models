namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountPaymentTerm
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual string note { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual string fiscal_country_codes { get; set; }
    public virtual long sequence { get; set; }
    public virtual object currency_id { get; set; }
    public virtual bool display_on_invoice { get; set; }
    public virtual string example_amount { get; set; }
    public virtual string example_date { get; set; }
    public virtual bool example_invalid { get; set; }
    public virtual string example_preview { get; set; }
    public virtual string example_preview_discount { get; set; }
    public virtual double discount_percentage { get; set; }
    public virtual long discount_days { get; set; }
    public virtual string early_pay_discount_computation { get; set; }
    public virtual bool early_discount { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}