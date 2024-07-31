namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class UtmCampaign
{
    public virtual bool active { get; set; }
    public virtual string name { get; set; }
    public virtual string title { get; set; }
    public virtual object user_id { get; set; }
    public virtual object stage_id { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual bool is_auto_campaign { get; set; }
    public virtual long color { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long quotation_count { get; set; }
    public virtual long invoiced_amount { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
}