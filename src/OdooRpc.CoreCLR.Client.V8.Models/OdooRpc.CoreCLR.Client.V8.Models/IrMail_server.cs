namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrMail_server
{
    public virtual string google_gmail_authorization_code { get; set; }
    public virtual string google_gmail_refresh_token { get; set; }
    public virtual string google_gmail_access_token { get; set; }
    public virtual long google_gmail_access_token_expiration { get; set; }
    public virtual string google_gmail_uri { get; set; }
    public virtual string name { get; set; }
    public virtual string from_filter { get; set; }
    public virtual string smtp_host { get; set; }
    public virtual long smtp_port { get; set; }
    public virtual string smtp_authentication { get; set; }
    public virtual string smtp_authentication_info { get; set; }
    public virtual string smtp_user { get; set; }
    public virtual string smtp_pass { get; set; }
    public virtual string smtp_encryption { get; set; }
    public virtual string smtp_ssl_certificate { get; set; }
    public virtual string smtp_ssl_private_key { get; set; }
    public virtual bool smtp_debug { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool active { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] mail_template_ids { get; set; }
}