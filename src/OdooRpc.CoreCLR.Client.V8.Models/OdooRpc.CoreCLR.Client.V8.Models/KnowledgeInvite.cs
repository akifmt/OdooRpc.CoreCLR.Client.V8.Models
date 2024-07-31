namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class KnowledgeInvite
{
    public virtual object article_id { get; set; }
    public virtual bool have_share_partners { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual string permission { get; set; }
    public virtual string message { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}