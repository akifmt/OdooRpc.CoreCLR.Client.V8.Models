namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class UomUom
{
    public virtual string name { get; set; }
    public virtual object category_id { get; set; }
    public virtual double factor { get; set; }
    public virtual double factor_inv { get; set; }
    public virtual double rounding { get; set; }
    public virtual bool active { get; set; }
    public virtual string uom_type { get; set; }
    public virtual double ratio { get; set; }
    public virtual long color { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual string fiscal_country_codes { get; set; }
}