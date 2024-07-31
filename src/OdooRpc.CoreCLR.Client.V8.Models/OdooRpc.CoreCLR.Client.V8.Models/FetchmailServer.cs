namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class FetchmailServer
{
    public virtual string google_gmail_authorization_code { get; set; }
    public virtual string google_gmail_refresh_token { get; set; }
    public virtual string google_gmail_access_token { get; set; }
    public virtual long google_gmail_access_token_expiration { get; set; }
    public virtual string google_gmail_uri { get; set; }
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual string state { get; set; }
    public virtual string server { get; set; }
    public virtual long port { get; set; }
    public virtual string server_type { get; set; }
    public virtual string server_type_info { get; set; }
    public virtual bool is_ssl { get; set; }
    public virtual bool attach { get; set; }
    public virtual bool original { get; set; }
    public virtual string date { get; set; }
    public virtual string user { get; set; }
    public virtual string password { get; set; }
    public virtual object object_id { get; set; }
    public virtual long priority { get; set; }
    public virtual long[] message_ids { get; set; }
    public virtual string configuration { get; set; }
    public virtual string script { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}