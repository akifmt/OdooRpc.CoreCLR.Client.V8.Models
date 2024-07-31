namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MailingList
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual long contact_count { get; set; }
    public virtual long contact_count_email { get; set; }
    public virtual long contact_count_opt_out { get; set; }
    public virtual double contact_pct_opt_out { get; set; }
    public virtual long contact_count_blacklisted { get; set; }
    public virtual double contact_pct_blacklisted { get; set; }
    public virtual double contact_pct_bounce { get; set; }
    public virtual long[] contact_ids { get; set; }
    public virtual long mailing_count { get; set; }
    public virtual long[] mailing_ids { get; set; }
    public virtual long[] subscription_ids { get; set; }
    public virtual bool is_public { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long contact_count_sms { get; set; }
}