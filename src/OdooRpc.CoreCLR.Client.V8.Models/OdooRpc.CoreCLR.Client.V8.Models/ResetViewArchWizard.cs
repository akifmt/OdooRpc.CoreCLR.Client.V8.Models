namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResetViewArchWizard
{
    public virtual object view_id { get; set; }
    public virtual string view_name { get; set; }
    public virtual bool has_diff { get; set; }
    public virtual string arch_diff { get; set; }
    public virtual string reset_mode { get; set; }
    public virtual object compare_view_id { get; set; }
    public virtual string arch_to_compare { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}