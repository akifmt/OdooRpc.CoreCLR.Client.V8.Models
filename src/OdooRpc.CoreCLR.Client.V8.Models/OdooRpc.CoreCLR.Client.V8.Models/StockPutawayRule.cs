namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockPutawayRule
{
    public virtual object product_id { get; set; }
    public virtual object category_id { get; set; }
    public virtual object location_in_id { get; set; }
    public virtual object location_out_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] package_type_ids { get; set; }
    public virtual object storage_category_id { get; set; }
    public virtual bool active { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}