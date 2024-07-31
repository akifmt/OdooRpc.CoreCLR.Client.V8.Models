namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrRule
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual object model_id { get; set; }
    public virtual long[] groups { get; set; }
    public virtual string domain_force { get; set; }
    public virtual bool perm_read { get; set; }
    public virtual bool perm_write { get; set; }
    public virtual bool perm_create { get; set; }
    public virtual bool perm_unlink { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool global { get; set; }
}