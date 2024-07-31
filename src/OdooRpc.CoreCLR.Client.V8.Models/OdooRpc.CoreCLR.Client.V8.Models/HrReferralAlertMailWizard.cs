namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrReferralAlertMailWizard
{
    public virtual long[] user_ids { get; set; }
    public virtual string subject { get; set; }
    public virtual string body { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}