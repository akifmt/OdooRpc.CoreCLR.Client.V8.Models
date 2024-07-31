namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignLog
{
    public virtual string log_date { get; set; }
    public virtual object sign_request_id { get; set; }
    public virtual object sign_request_item_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual double latitude { get; set; }
    public virtual double longitude { get; set; }
    public virtual string ip { get; set; }
    public virtual string log_hash { get; set; }
    public virtual string token { get; set; }
    public virtual string action { get; set; }
    public virtual string request_state { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}