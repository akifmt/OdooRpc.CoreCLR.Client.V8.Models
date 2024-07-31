namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleOrderLog
{
    public virtual object order_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual object team_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object origin_order_id { get; set; }
    public virtual string event_type { get; set; }
    public virtual string event_date { get; set; }
    public virtual string recurring_monthly { get; set; }
    public virtual string amount_signed { get; set; }
    public virtual string subscription_state { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}