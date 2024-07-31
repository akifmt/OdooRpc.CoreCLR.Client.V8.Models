namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountResequenceWizard
{
    public virtual string sequence_number_reset { get; set; }
    public virtual string first_date { get; set; }
    public virtual string end_date { get; set; }
    public virtual string first_name { get; set; }
    public virtual string ordering { get; set; }
    public virtual long[] move_ids { get; set; }
    public virtual string new_values { get; set; }
    public virtual string preview_moves { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}