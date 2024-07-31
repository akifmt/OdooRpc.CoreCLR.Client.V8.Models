namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PurchaseOrderLine
{
    public virtual string analytic_distribution { get; set; }
    public virtual long analytic_precision { get; set; }
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual double product_qty { get; set; }
    public virtual double product_uom_qty { get; set; }
    public virtual string date_planned { get; set; }
    public virtual double discount { get; set; }
    public virtual long[] taxes_id { get; set; }
    public virtual object product_uom { get; set; }
    public virtual object product_uom_category_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual string product_type { get; set; }
    public virtual double price_unit { get; set; }
    public virtual double price_unit_discounted { get; set; }
    public virtual string price_subtotal { get; set; }
    public virtual string price_total { get; set; }
    public virtual double price_tax { get; set; }
    public virtual object order_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string state { get; set; }
    public virtual long[] invoice_lines { get; set; }
    public virtual double qty_invoiced { get; set; }
    public virtual string qty_received_method { get; set; }
    public virtual double qty_received { get; set; }
    public virtual double qty_received_manual { get; set; }
    public virtual double qty_to_invoice { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string date_order { get; set; }
    public virtual string date_approve { get; set; }
    public virtual object product_packaging_id { get; set; }
    public virtual double product_packaging_qty { get; set; }
    public virtual string tax_calculation_rounding_method { get; set; }
    public virtual string display_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] move_ids { get; set; }
    public virtual object orderpoint_id { get; set; }
    public virtual long[] move_dest_ids { get; set; }
    public virtual string product_description_variants { get; set; }
    public virtual bool propagate_cancel { get; set; }
    public virtual bool forecasted_issue { get; set; }
    public virtual object location_final_id { get; set; }
}