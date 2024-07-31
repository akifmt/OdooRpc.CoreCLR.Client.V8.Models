namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SpreadsheetRevision
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual string res_model { get; set; }
    public virtual string res_id { get; set; }
    public virtual string commands { get; set; }
    public virtual string revision_uuid { get; set; }
    public virtual object parent_revision_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}