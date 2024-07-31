namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrModelData
{
    public virtual string name { get; set; }
    public virtual string complete_name { get; set; }
    public virtual string model { get; set; }
    public virtual string module { get; set; }
    public virtual string res_id { get; set; }
    public virtual bool noupdate { get; set; }
    public virtual string reference { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}