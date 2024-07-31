namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ValidateAccountMove
{
    public virtual long[] move_ids { get; set; }
    public virtual bool force_post { get; set; }
    public virtual bool display_force_post { get; set; }
    public virtual long[] abnormal_date_partner_ids { get; set; }
    public virtual bool ignore_abnormal_date { get; set; }
    public virtual long[] abnormal_amount_partner_ids { get; set; }
    public virtual bool ignore_abnormal_amount { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}