namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class WebsiteVisitorPushSubscription
{
    public virtual object website_visitor_id { get; set; }
    public virtual string push_token { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}