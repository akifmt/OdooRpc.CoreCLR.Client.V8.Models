namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PosCloseSessionWizard
{
    public virtual double amount_to_balance { get; set; }
    public virtual object account_id { get; set; }
    public virtual bool account_readonly { get; set; }
    public virtual string message { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}