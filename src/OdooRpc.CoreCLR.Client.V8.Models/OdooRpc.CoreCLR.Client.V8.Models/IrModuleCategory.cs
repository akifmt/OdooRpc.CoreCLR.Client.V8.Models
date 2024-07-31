namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrModuleCategory
{
    public virtual string name { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] child_ids { get; set; }
    public virtual long[] module_ids { get; set; }
    public virtual string description { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool visible { get; set; }
    public virtual bool exclusive { get; set; }
    public virtual string xml_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}