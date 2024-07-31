using System.Text.Json.Serialization;

namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductPricelistItem
{
    public virtual object pricelist_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string date_start { get; set; }
    public virtual string date_end { get; set; }
    public virtual double min_quantity { get; set; }
    public virtual string applied_on { get; set; }
    public virtual object categ_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object product_id { get; set; }

    [JsonPropertyName("base")]
    public virtual string base_ { get; set; }

    public virtual object base_pricelist_id { get; set; }
    public virtual string compute_price { get; set; }
    public virtual double fixed_price { get; set; }
    public virtual double percent_price { get; set; }
    public virtual double price_discount { get; set; }
    public virtual double price_round { get; set; }
    public virtual double price_surcharge { get; set; }
    public virtual double price_min_margin { get; set; }
    public virtual double price_max_margin { get; set; }
    public virtual string name { get; set; }
    public virtual string price { get; set; }
    public virtual string rule_tip { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}