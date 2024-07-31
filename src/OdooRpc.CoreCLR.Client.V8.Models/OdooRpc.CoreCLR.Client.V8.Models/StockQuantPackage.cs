namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockQuantPackage
{
    public virtual string name { get; set; }
    public virtual long[] quant_ids { get; set; }
    public virtual object package_type_id { get; set; }
    public virtual object location_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object owner_id { get; set; }
    public virtual string package_use { get; set; }
    public virtual bool valid_sscc { get; set; }
    public virtual string pack_date { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}