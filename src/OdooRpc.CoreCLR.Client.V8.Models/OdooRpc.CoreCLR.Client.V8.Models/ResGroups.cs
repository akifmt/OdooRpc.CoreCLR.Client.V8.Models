namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResGroups
{
    public virtual string name { get; set; }
    public virtual long[] users { get; set; }
    public virtual long[] model_access { get; set; }
    public virtual long[] rule_groups { get; set; }
    public virtual long[] menu_access { get; set; }
    public virtual long[] view_access { get; set; }
    public virtual string comment { get; set; }
    public virtual object category_id { get; set; }
    public virtual long color { get; set; }
    public virtual string full_name { get; set; }
    public virtual bool share { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] implied_ids { get; set; }
    public virtual long[] trans_implied_ids { get; set; }
}