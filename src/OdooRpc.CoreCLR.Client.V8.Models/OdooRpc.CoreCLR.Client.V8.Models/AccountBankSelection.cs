namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountBankSelection
{
    public virtual object account_online_link_id { get; set; }
    public virtual long[] account_online_account_ids { get; set; }
    public virtual string institution_name { get; set; }
    public virtual object selected_account { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}