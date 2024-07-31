namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductTemplateAttributeLine
{
    public virtual bool active { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual object attribute_id { get; set; }
    public virtual long[] value_ids { get; set; }
    public virtual long value_count { get; set; }
    public virtual long[] product_template_value_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}