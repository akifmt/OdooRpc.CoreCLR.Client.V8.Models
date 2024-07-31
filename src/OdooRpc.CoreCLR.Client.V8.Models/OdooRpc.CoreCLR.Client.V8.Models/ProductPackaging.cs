namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ProductPackaging
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual object product_id { get; set; }
    public virtual double qty { get; set; }
    public virtual string barcode { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool sales { get; set; }
}