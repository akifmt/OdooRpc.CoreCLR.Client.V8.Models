namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountTransferModel
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual object journal_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string date_start { get; set; }
    public virtual string date_stop { get; set; }
    public virtual string frequency { get; set; }
    public virtual long[] account_ids { get; set; }
    public virtual long[] line_ids { get; set; }
    public virtual long[] move_ids { get; set; }
    public virtual long move_ids_count { get; set; }
    public virtual double total_percent { get; set; }
    public virtual string state { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}