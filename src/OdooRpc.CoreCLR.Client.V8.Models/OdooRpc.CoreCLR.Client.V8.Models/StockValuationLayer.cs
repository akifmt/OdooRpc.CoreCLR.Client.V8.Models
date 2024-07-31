namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockValuationLayer
{
    public virtual object company_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object categ_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual double quantity { get; set; }
    public virtual object uom_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual double unit_cost { get; set; }
    public virtual string value { get; set; }
    public virtual double remaining_qty { get; set; }
    public virtual string remaining_value { get; set; }
    public virtual string description { get; set; }
    public virtual object stock_valuation_layer_id { get; set; }
    public virtual long[] stock_valuation_layer_ids { get; set; }
    public virtual object stock_move_id { get; set; }
    public virtual object account_move_id { get; set; }
    public virtual object account_move_line_id { get; set; }
    public virtual string reference { get; set; }
    public virtual double price_diff_value { get; set; }
    public virtual object warehouse_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}