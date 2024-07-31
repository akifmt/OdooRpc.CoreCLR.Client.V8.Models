namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PaymentRefundWizard
{
    public virtual object payment_id { get; set; }
    public virtual object transaction_id { get; set; }
    public virtual string payment_amount { get; set; }
    public virtual string refunded_amount { get; set; }
    public virtual string amount_available_for_refund { get; set; }
    public virtual string amount_to_refund { get; set; }
    public virtual object currency_id { get; set; }
    public virtual string support_refund { get; set; }
    public virtual bool has_pending_refund { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}