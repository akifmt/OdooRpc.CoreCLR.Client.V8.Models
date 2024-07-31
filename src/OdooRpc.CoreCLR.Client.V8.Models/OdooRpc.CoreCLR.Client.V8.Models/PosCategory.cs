namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PosCategory
{
    public virtual string name { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] child_id { get; set; }
    public virtual long sequence { get; set; }
    public virtual string image_128 { get; set; }
    public virtual long color { get; set; }
    public virtual bool has_image { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual double hour_until { get; set; }
    public virtual double hour_after { get; set; }
}