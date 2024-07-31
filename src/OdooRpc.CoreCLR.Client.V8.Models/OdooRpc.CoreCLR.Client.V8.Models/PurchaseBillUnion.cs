namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PurchaseBillUnion
{
    public virtual string name { get; set; }
    public virtual string reference { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string date { get; set; }
    public virtual double amount { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual object vendor_bill_id { get; set; }
    public virtual object purchase_order_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}