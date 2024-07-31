namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockRoute
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual long sequence { get; set; }
    public virtual long[] rule_ids { get; set; }
    public virtual bool product_selectable { get; set; }
    public virtual bool product_categ_selectable { get; set; }
    public virtual bool warehouse_selectable { get; set; }
    public virtual bool packaging_selectable { get; set; }
    public virtual object supplied_wh_id { get; set; }
    public virtual object supplier_wh_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual long[] product_ids { get; set; }
    public virtual long[] categ_ids { get; set; }
    public virtual long[] packaging_ids { get; set; }
    public virtual long[] warehouse_domain_ids { get; set; }
    public virtual long[] warehouse_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool sale_selectable { get; set; }
}