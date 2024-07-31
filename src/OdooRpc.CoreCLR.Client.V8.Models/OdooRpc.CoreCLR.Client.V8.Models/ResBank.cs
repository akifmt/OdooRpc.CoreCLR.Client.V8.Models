namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResBank
{
    public virtual string name { get; set; }
    public virtual string street { get; set; }
    public virtual string street2 { get; set; }
    public virtual string zip { get; set; }
    public virtual string city { get; set; }
    public virtual object state { get; set; }
    public virtual object country { get; set; }
    public virtual string email { get; set; }
    public virtual string phone { get; set; }
    public virtual bool active { get; set; }
    public virtual string bic { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}