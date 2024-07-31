namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountFinancialYearOp
{
    public virtual object company_id { get; set; }
    public virtual bool opening_move_posted { get; set; }
    public virtual string opening_date { get; set; }
    public virtual long fiscalyear_last_day { get; set; }
    public virtual string fiscalyear_last_month { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}