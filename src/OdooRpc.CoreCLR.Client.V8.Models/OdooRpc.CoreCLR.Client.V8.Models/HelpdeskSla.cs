namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HelpdeskSla
{
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual bool active { get; set; }
    public virtual object team_id { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual object stage_id { get; set; }
    public virtual long[] exclude_stage_ids { get; set; }
    public virtual string priority { get; set; }
    public virtual long[] partner_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual double time { get; set; }
    public virtual long ticket_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}