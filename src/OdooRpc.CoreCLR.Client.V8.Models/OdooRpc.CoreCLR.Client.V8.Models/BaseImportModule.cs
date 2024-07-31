namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BaseImportModule
{
    public virtual string module_file { get; set; }
    public virtual string state { get; set; }
    public virtual string import_message { get; set; }
    public virtual bool force { get; set; }
    public virtual bool with_demo { get; set; }
    public virtual string modules_dependencies { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}