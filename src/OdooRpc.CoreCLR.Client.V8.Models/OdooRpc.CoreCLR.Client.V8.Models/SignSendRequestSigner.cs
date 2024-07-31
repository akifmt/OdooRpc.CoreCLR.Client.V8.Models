namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SignSendRequestSigner
{
    public virtual object role_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual long mail_sent_order { get; set; }
    public virtual object sign_send_request_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}