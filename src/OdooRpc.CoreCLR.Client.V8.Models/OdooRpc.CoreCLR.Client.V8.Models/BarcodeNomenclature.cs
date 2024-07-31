namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BarcodeNomenclature
{
    public virtual string name { get; set; }
    public virtual long[] rule_ids { get; set; }
    public virtual string upc_ean_conv { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool is_gs1_nomenclature { get; set; }
    public virtual string gs1_separator_fnc1 { get; set; }
}