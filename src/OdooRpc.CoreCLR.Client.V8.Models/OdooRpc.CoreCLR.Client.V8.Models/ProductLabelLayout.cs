namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductLabelLayout
{
    public virtual string print_format { get; set; }
    public virtual long custom_quantity { get; set; }
    public virtual long[] product_ids { get; set; }
    public virtual long[] product_tmpl_ids { get; set; }
    public virtual string extra_html { get; set; }
    public virtual long rows { get; set; }
    public virtual long columns { get; set; }
    public virtual object pricelist_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}