namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PurchaseReport
{
    public virtual string date_order { get; set; }
    public virtual string state { get; set; }
    public virtual object product_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string date_approve { get; set; }
    public virtual object product_uom { get; set; }
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual double delay { get; set; }
    public virtual double delay_pass { get; set; }
    public virtual double price_total { get; set; }
    public virtual double price_average { get; set; }
    public virtual long nbr_lines { get; set; }
    public virtual object category_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object country_id { get; set; }
    public virtual object fiscal_position_id { get; set; }
    public virtual object commercial_partner_id { get; set; }
    public virtual double weight { get; set; }
    public virtual double volume { get; set; }
    public virtual object order_id { get; set; }
    public virtual double untaxed_total { get; set; }
    public virtual double qty_ordered { get; set; }
    public virtual double qty_received { get; set; }
    public virtual double qty_billed { get; set; }
    public virtual double qty_to_be_billed { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object picking_type_id { get; set; }
    public virtual string effective_date { get; set; }
}