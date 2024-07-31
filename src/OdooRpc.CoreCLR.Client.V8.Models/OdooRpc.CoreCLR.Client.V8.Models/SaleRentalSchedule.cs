namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleRentalSchedule
{
    public virtual string name { get; set; }
    public virtual string product_name { get; set; }
    public virtual string description { get; set; }
    public virtual string order_date { get; set; }
    public virtual string pickup_date { get; set; }
    public virtual string return_date { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_uom { get; set; }
    public virtual double product_uom_qty { get; set; }
    public virtual double qty_delivered { get; set; }
    public virtual double qty_returned { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string card_name { get; set; }
    public virtual object company_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual object categ_id { get; set; }
    public virtual object analytic_account_id { get; set; }
    public virtual object team_id { get; set; }
    public virtual object country_id { get; set; }
    public virtual object commercial_partner_id { get; set; }
    public virtual string rental_status { get; set; }
    public virtual string state { get; set; }
    public virtual object order_id { get; set; }
    public virtual object order_line_id { get; set; }
    public virtual string report_line_status { get; set; }
    public virtual long color { get; set; }
    public virtual bool late { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual bool is_available { get; set; }
    public virtual object lot_id { get; set; }
    public virtual object warehouse_id { get; set; }
}