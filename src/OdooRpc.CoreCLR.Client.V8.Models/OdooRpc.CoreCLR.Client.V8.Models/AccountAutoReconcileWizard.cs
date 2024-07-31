namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountAutoReconcileWizard
{
    public virtual object company_id { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual string from_date { get; set; }
    public virtual string to_date { get; set; }
    public virtual long[] account_ids { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual string search_mode { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}