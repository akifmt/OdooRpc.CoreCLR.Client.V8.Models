namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PaymentCaptureWizard
{
    public virtual long[] transaction_ids { get; set; }
    public virtual string authorized_amount { get; set; }
    public virtual string captured_amount { get; set; }
    public virtual string voided_amount { get; set; }
    public virtual string available_amount { get; set; }
    public virtual string amount_to_capture { get; set; }
    public virtual bool is_amount_to_capture_valid { get; set; }
    public virtual bool void_remaining_amount { get; set; }
    public virtual object currency_id { get; set; }
    public virtual bool support_partial_capture { get; set; }
    public virtual bool has_draft_children { get; set; }
    public virtual bool has_remaining_amount { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}