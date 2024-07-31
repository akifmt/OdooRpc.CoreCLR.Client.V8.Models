namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpBomByproduct
{
    public virtual object product_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual double product_qty { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object bom_id { get; set; }
    public virtual long[] allowed_operation_ids { get; set; }
    public virtual object operation_id { get; set; }
    public virtual long[] possible_bom_product_template_attribute_value_ids { get; set; }
    public virtual long[] bom_product_template_attribute_value_ids { get; set; }
    public virtual long sequence { get; set; }
    public virtual double cost_share { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}