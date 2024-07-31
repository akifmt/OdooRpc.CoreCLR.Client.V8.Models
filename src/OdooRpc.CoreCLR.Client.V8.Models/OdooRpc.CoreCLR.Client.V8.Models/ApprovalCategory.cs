namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ApprovalCategory
{
    public virtual string name { get; set; }
    public virtual object company_id { get; set; }
    public virtual bool active { get; set; }
    public virtual long sequence { get; set; }
    public virtual string description { get; set; }
    public virtual string image { get; set; }
    public virtual string has_date { get; set; }
    public virtual string has_period { get; set; }
    public virtual string has_quantity { get; set; }
    public virtual string has_amount { get; set; }
    public virtual string has_reference { get; set; }
    public virtual string has_partner { get; set; }
    public virtual string has_payment_method { get; set; }
    public virtual string has_location { get; set; }
    public virtual string has_product { get; set; }
    public virtual string requirer_document { get; set; }
    public virtual long approval_minimum { get; set; }
    public virtual bool invalid_minimum { get; set; }
    public virtual string invalid_minimum_warning { get; set; }
    public virtual string approval_type { get; set; }
    public virtual string manager_approval { get; set; }
    public virtual long[] user_ids { get; set; }
    public virtual long[] approver_ids { get; set; }
    public virtual bool approver_sequence { get; set; }
    public virtual long request_to_validate_count { get; set; }
    public virtual bool automated_sequence { get; set; }
    public virtual string sequence_code { get; set; }
    public virtual object sequence_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}