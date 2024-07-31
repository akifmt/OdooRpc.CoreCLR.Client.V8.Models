namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResUsersDeletion
{
    public virtual object user_id { get; set; }
    public virtual long user_id_int { get; set; }
    public virtual string state { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}