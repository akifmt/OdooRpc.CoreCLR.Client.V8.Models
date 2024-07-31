namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class LunchCashmove
{
    public virtual object currency_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual string date { get; set; }
    public virtual double amount { get; set; }
    public virtual string description { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}