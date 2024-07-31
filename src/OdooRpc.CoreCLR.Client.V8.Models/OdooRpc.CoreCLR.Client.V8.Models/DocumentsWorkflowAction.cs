namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DocumentsWorkflowAction
{
    public virtual object workflow_rule_id { get; set; }
    public virtual string action { get; set; }
    public virtual object facet_id { get; set; }
    public virtual object tag_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}