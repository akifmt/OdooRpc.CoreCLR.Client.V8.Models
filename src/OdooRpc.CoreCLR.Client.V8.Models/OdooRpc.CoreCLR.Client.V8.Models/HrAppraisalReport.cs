namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrAppraisalReport
{
    public virtual string name { get; set; }
    public virtual string create_date { get; set; }
    public virtual object department_id { get; set; }
    public virtual string deadline { get; set; }
    public virtual string final_interview { get; set; }
    public virtual object employee_id { get; set; }
    public virtual string state { get; set; }
    public virtual long color { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}