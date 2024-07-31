namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountTransferModelLine
{
    public virtual object transfer_model_id { get; set; }
    public virtual object account_id { get; set; }
    public virtual double percent { get; set; }
    public virtual long[] analytic_account_ids { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual bool percent_is_readonly { get; set; }
    public virtual long sequence { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}