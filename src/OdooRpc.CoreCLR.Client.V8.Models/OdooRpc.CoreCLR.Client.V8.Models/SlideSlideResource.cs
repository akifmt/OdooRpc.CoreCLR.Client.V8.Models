namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SlideSlideResource
{
    public virtual object slide_id { get; set; }
    public virtual string resource_type { get; set; }
    public virtual string name { get; set; }
    public virtual string data { get; set; }
    public virtual string file_name { get; set; }
    public virtual string link { get; set; }
    public virtual string download_url { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}