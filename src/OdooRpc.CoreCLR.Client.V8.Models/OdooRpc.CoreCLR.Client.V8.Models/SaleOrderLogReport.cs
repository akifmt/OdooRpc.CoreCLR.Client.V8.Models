namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleOrderLogReport
{
    public virtual object partner_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual object team_id { get; set; }
    public virtual string client_order_ref { get; set; }
    public virtual string event_type { get; set; }
    public virtual string event_date { get; set; }
    public virtual long contract_number { get; set; }
    public virtual object pricelist_id { get; set; }
    public virtual string amount_signed { get; set; }
    public virtual string mrr_change_normalized { get; set; }
    public virtual string arr_change_normalized { get; set; }
    public virtual string recurring_monthly { get; set; }
    public virtual string recurring_yearly { get; set; }
    public virtual object template_id { get; set; }
    public virtual object plan_id { get; set; }
    public virtual object country_id { get; set; }
    public virtual object industry_id { get; set; }
    public virtual object commercial_partner_id { get; set; }
    public virtual string subscription_state { get; set; }
    public virtual string state { get; set; }
    public virtual string health { get; set; }
    public virtual object campaign_id { get; set; }
    public virtual object origin_order_id { get; set; }
    public virtual object order_id { get; set; }
    public virtual string first_contract_date { get; set; }
    public virtual string end_date { get; set; }
    public virtual object close_reason_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object log_currency_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}