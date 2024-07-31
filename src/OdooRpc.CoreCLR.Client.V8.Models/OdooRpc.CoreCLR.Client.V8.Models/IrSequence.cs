namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrSequence
{
    public virtual string name { get; set; }
    public virtual string code { get; set; }
    public virtual string implementation { get; set; }
    public virtual bool active { get; set; }
    public virtual string prefix { get; set; }
    public virtual string suffix { get; set; }
    public virtual long number_next { get; set; }
    public virtual long number_next_actual { get; set; }
    public virtual long number_increment { get; set; }
    public virtual long padding { get; set; }
    public virtual object company_id { get; set; }
    public virtual bool use_date_range { get; set; }
    public virtual long[] date_range_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}