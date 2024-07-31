﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleReport
{
    public virtual string name { get; set; }
    public virtual string date { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object pricelist_id { get; set; }
    public virtual object team_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual string state { get; set; }
    public virtual object analytic_account_id { get; set; }
    public virtual string invoice_status { get; set; }
    public virtual object campaign_id { get; set; }
    public virtual object medium_id { get; set; }
    public virtual object source_id { get; set; }
    public virtual object commercial_partner_id { get; set; }
    public virtual object country_id { get; set; }
    public virtual object industry_id { get; set; }
    public virtual string partner_zip { get; set; }
    public virtual object state_id { get; set; }
    public virtual string order_reference { get; set; }
    public virtual object categ_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object product_uom { get; set; }
    public virtual double product_uom_qty { get; set; }
    public virtual double qty_to_deliver { get; set; }
    public virtual double qty_delivered { get; set; }
    public virtual double qty_to_invoice { get; set; }
    public virtual double qty_invoiced { get; set; }
    public virtual string price_subtotal { get; set; }
    public virtual string price_total { get; set; }
    public virtual string untaxed_amount_to_invoice { get; set; }
    public virtual string untaxed_amount_invoiced { get; set; }
    public virtual double weight { get; set; }
    public virtual double volume { get; set; }
    public virtual double discount { get; set; }
    public virtual string discount_amount { get; set; }
    public virtual long nbr { get; set; }
    public virtual object currency_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object website_id { get; set; }
    public virtual bool is_abandoned_cart { get; set; }
}