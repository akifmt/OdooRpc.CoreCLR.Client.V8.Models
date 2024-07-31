namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AccountInvoiceReport
{
    public virtual object move_id { get; set; }
    public virtual object journal_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object company_currency_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object commercial_partner_id { get; set; }
    public virtual object country_id { get; set; }
    public virtual object invoice_user_id { get; set; }
    public virtual string move_type { get; set; }
    public virtual string state { get; set; }
    public virtual string payment_state { get; set; }
    public virtual object fiscal_position_id { get; set; }
    public virtual string invoice_date { get; set; }
    public virtual double quantity { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object product_categ_id { get; set; }
    public virtual string invoice_date_due { get; set; }
    public virtual object account_id { get; set; }
    public virtual double price_subtotal { get; set; }
    public virtual double price_total { get; set; }
    public virtual double price_average { get; set; }
    public virtual double price_margin { get; set; }
    public virtual double inventory_value { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object team_id { get; set; }
}