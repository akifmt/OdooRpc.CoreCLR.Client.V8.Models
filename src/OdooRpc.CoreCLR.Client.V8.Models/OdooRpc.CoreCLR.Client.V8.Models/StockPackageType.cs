namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockPackageType
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual double height { get; set; }
    public virtual double width { get; set; }
    public virtual double packaging_length { get; set; }
    public virtual double base_weight { get; set; }
    public virtual double max_weight { get; set; }
    public virtual string barcode { get; set; }
    public virtual string weight_uom_name { get; set; }
    public virtual string length_uom_name { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] storage_category_capacity_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}