namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class GoogleGmailMixin
{
    public virtual string google_gmail_authorization_code { get; set; }
    public virtual string google_gmail_refresh_token { get; set; }
    public virtual string google_gmail_access_token { get; set; }
    public virtual long google_gmail_access_token_expiration { get; set; }
    public virtual string google_gmail_uri { get; set; }
}