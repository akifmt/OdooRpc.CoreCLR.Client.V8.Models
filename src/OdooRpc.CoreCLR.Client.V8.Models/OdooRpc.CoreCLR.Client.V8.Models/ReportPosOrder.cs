namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ReportPosOrder
{
    public virtual string date { get; set; }
    public virtual object order_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object product_id { get; set; }
    public virtual object product_tmpl_id { get; set; }
    public virtual string state { get; set; }
    public virtual object user_id { get; set; }
    public virtual double price_total { get; set; }
    public virtual double price_sub_total { get; set; }
    public virtual double total_discount { get; set; }
    public virtual double average_price { get; set; }
    public virtual object company_id { get; set; }
    public virtual long nbr_lines { get; set; }
    public virtual long product_qty { get; set; }
    public virtual object journal_id { get; set; }
    public virtual long delay_validation { get; set; }
    public virtual object product_categ_id { get; set; }
    public virtual bool invoiced { get; set; }
    public virtual object config_id { get; set; }
    public virtual object pricelist_id { get; set; }
    public virtual object session_id { get; set; }
    public virtual double margin { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object employee_id { get; set; }
}