namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleOrderTemplateLine
{
    public virtual object sale_order_template_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual object company_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual string name { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual double product_uom_qty { get; set; }
    public virtual string display_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool recurring_invoice { get; set; }
}