namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PortalShare
{
    public virtual string res_model { get; set; }
    public virtual long res_id { get; set; }
    public virtual string resource_ref { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual string note { get; set; }
    public virtual string share_link { get; set; }
    public virtual string access_warning { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}