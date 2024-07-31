namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountTaxUnit
{
    public virtual string name { get; set; }
    public virtual object country_id { get; set; }
    public virtual string vat { get; set; }
    public virtual long[] company_ids { get; set; }
    public virtual object main_company_id { get; set; }
    public virtual bool fpos_synced { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}