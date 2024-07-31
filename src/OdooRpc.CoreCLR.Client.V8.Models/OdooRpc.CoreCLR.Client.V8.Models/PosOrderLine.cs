namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PosOrderLine
{
    public virtual object company_id { get; set; }
    public virtual string name { get; set; }
    public virtual bool skip_change { get; set; }
    public virtual string notice { get; set; }
    public virtual object product_id { get; set; }
    public virtual long[] attribute_value_ids { get; set; }
    public virtual long[] custom_attribute_value_ids { get; set; }
    public virtual double price_unit { get; set; }
    public virtual double qty { get; set; }
    public virtual double price_subtotal { get; set; }
    public virtual double price_subtotal_incl { get; set; }
    public virtual double price_extra { get; set; }
    public virtual string margin { get; set; }
    public virtual double margin_percent { get; set; }
    public virtual double total_cost { get; set; }
    public virtual bool is_total_cost_computed { get; set; }
    public virtual double discount { get; set; }
    public virtual object order_id { get; set; }
    public virtual long[] tax_ids { get; set; }
    public virtual long[] tax_ids_after_fiscal_position { get; set; }
    public virtual long[] pack_lot_ids { get; set; }
    public virtual object product_uom_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string full_product_name { get; set; }
    public virtual string customer_note { get; set; }
    public virtual long[] refund_orderline_ids { get; set; }
    public virtual object refunded_orderline_id { get; set; }
    public virtual double refunded_qty { get; set; }
    public virtual string uuid { get; set; }
    public virtual string note { get; set; }
    public virtual object combo_parent_id { get; set; }
    public virtual long[] combo_line_ids { get; set; }
    public virtual object combo_line_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object sale_order_origin_id { get; set; }
    public virtual object sale_order_line_id { get; set; }
    public virtual string down_payment_details { get; set; }
    public virtual object combo_id { get; set; }
}