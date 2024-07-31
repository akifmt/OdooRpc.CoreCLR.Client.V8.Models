namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrModuleModuleExclusion
{
    public virtual string name { get; set; }
    public virtual object module_id { get; set; }
    public virtual object exclusion_id { get; set; }
    public virtual string state { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}