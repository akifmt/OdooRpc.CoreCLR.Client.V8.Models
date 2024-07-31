namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockValuationLayerRevaluation
{
    public virtual object company_id { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual string property_valuation { get; set; }
    public virtual string product_uom_name { get; set; }
    public virtual double current_value_svl { get; set; }
    public virtual double current_quantity_svl { get; set; }
    public virtual string added_value { get; set; }
    public virtual string new_value { get; set; }
    public virtual string new_value_by_qty { get; set; }
    public virtual string reason { get; set; }
    public virtual object account_journal_id { get; set; }
    public virtual object account_id { get; set; }
    public virtual string date { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}