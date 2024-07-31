namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockStorageCategoryCapacity
{
    public virtual object storage_category_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object package_type_id { get; set; }
    public virtual double quantity { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}