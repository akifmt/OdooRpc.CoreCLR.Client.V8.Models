namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrModuleModuleDependency
{
    public virtual string name { get; set; }
    public virtual object module_id { get; set; }
    public virtual object depend_id { get; set; }
    public virtual string state { get; set; }
    public virtual bool auto_install_required { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}