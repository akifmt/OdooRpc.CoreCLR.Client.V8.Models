namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductSupplierinfo
{
    public virtual object partner_id { get; set; }
    public virtual string product_name { get; set; }
    public virtual string product_code { get; set; }
    public virtual long sequence { get; set; }
    public virtual object product_uom { get; set; }
    public virtual double min_qty { get; set; }
    public virtual double price { get; set; }
    public virtual double price_discounted { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string date_start { get; set; }
    public virtual string date_end { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual long product_variant_count { get; set; }
    public virtual long delay { get; set; }
    public virtual double discount { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}