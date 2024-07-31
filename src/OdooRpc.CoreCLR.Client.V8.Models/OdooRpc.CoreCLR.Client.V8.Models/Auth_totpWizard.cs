namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Auth_totpWizard
{
    public virtual object user_id { get; set; }
    public virtual string secret { get; set; }
    public virtual string url { get; set; }
    public virtual string qrcode { get; set; }
    public virtual string code { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}