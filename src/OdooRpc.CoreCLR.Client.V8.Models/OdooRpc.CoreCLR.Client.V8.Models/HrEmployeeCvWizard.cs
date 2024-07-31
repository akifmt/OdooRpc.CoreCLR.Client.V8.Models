namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrEmployeeCvWizard
{
    public virtual long[] employee_ids { get; set; }
    public virtual string color_primary { get; set; }
    public virtual string color_secondary { get; set; }
    public virtual bool show_skills { get; set; }
    public virtual bool show_contact { get; set; }
    public virtual bool show_others { get; set; }
    public virtual bool can_show_others { get; set; }
    public virtual bool can_show_skills { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}