namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BaseLanguageExport
{
    public virtual string name { get; set; }
    public virtual string lang { get; set; }
    public virtual string format { get; set; }
    public virtual string export_type { get; set; }
    public virtual long[] modules { get; set; }
    public virtual object model_id { get; set; }
    public virtual string model_name { get; set; }
    public virtual string domain { get; set; }
    public virtual string data { get; set; }
    public virtual string state { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}