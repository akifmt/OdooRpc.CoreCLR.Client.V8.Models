namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailLinkPreview
{
    public virtual object message_id { get; set; }
    public virtual bool is_hidden { get; set; }
    public virtual string source_url { get; set; }
    public virtual string og_type { get; set; }
    public virtual string og_title { get; set; }
    public virtual string og_site_name { get; set; }
    public virtual string og_image { get; set; }
    public virtual string og_description { get; set; }
    public virtual string og_mimetype { get; set; }
    public virtual string image_mimetype { get; set; }
    public virtual string create_date { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}