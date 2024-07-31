namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DeliveryCarrier
{
    public virtual object website_id { get; set; }
    public virtual bool website_published { get; set; }
    public virtual bool is_published { get; set; }
    public virtual bool can_publish { get; set; }
    public virtual string website_url { get; set; }
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual long sequence { get; set; }
    public virtual string delivery_type { get; set; }
    public virtual string integration_level { get; set; }
    public virtual bool prod_environment { get; set; }
    public virtual bool debug_logging { get; set; }
    public virtual object company_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string invoice_policy { get; set; }
    public virtual long[] country_ids { get; set; }
    public virtual long[] state_ids { get; set; }
    public virtual long[] zip_prefix_ids { get; set; }
    public virtual string carrier_description { get; set; }
    public virtual double margin { get; set; }
    public virtual double fixed_margin { get; set; }
    public virtual bool free_over { get; set; }
    public virtual double amount { get; set; }
    public virtual bool can_generate_return { get; set; }
    public virtual bool return_label_on_delivery { get; set; }
    public virtual bool get_return_label_from_portal { get; set; }
    public virtual bool supports_shipping_insurance { get; set; }
    public virtual long shipping_insurance { get; set; }
    public virtual long[] price_rule_ids { get; set; }
    public virtual double fixed_price { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string website_description { get; set; }
}