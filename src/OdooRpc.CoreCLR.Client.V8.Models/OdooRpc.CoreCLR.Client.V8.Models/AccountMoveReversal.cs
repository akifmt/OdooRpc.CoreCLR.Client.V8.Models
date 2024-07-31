namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountMoveReversal
{
    public virtual long[] move_ids { get; set; }
    public virtual long[] new_move_ids { get; set; }
    public virtual string date { get; set; }
    public virtual string reason { get; set; }
    public virtual object journal_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] available_journal_ids { get; set; }
    public virtual string country_code { get; set; }
    public virtual string residual { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string move_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}