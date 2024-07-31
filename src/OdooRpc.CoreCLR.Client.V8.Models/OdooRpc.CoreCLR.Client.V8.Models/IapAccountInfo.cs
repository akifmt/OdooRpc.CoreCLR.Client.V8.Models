namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IapAccountInfo
{
    public virtual object account_id { get; set; }
    public virtual string account_token { get; set; }
    public virtual double balance { get; set; }
    public virtual string account_uuid_hashed { get; set; }
    public virtual string service_name { get; set; }
    public virtual string description { get; set; }
    public virtual bool warn_me { get; set; }
    public virtual double warning_threshold { get; set; }
    public virtual string warning_email { get; set; }
    public virtual string unit_name { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}