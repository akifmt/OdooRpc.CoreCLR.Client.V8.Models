namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ApplicantGetRefuseReason
{
    public virtual object refuse_reason_id { get; set; }
    public virtual long[] applicant_ids { get; set; }
    public virtual bool send_mail { get; set; }
    public virtual object template_id { get; set; }
    public virtual string applicant_without_email { get; set; }
    public virtual string applicant_emails { get; set; }
    public virtual bool duplicates { get; set; }
    public virtual long duplicates_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}