namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SaleAdvancePaymentInv
{
    public virtual string advance_payment_method { get; set; }
    public virtual long count { get; set; }
    public virtual long[] sale_order_ids { get; set; }
    public virtual bool has_down_payments { get; set; }
    public virtual bool deduct_down_payments { get; set; }
    public virtual double amount { get; set; }
    public virtual string fixed_amount { get; set; }
    public virtual object currency_id { get; set; }
    public virtual object company_id { get; set; }
    public virtual string amount_invoiced { get; set; }
    public virtual string amount_to_invoice { get; set; }
    public virtual bool display_draft_invoice_warning { get; set; }
    public virtual bool display_invoice_amount_warning { get; set; }
    public virtual bool consolidated_billing { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}