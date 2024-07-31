namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockQuantRelocate
{
    public virtual long[] quant_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual object dest_location_id { get; set; }
    public virtual string dest_package_id_domain { get; set; }
    public virtual object dest_package_id { get; set; }
    public virtual string message { get; set; }
    public virtual bool is_partial_package { get; set; }
    public virtual string partial_package_names { get; set; }
    public virtual bool is_multi_location { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}