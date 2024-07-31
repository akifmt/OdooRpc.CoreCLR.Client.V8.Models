namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class EventTagCategory
{
    public virtual object website_id { get; set; }
    public virtual bool website_published { get; set; }
    public virtual bool is_published { get; set; }
    public virtual bool can_publish { get; set; }
    public virtual string website_url { get; set; }
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}