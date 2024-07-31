namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrResumeLine
{
    public virtual object employee_id { get; set; }
    public virtual string name { get; set; }
    public virtual string date_start { get; set; }
    public virtual string date_end { get; set; }
    public virtual string description { get; set; }
    public virtual object line_type_id { get; set; }
    public virtual string display_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object department_id { get; set; }
    public virtual object survey_id { get; set; }
    public virtual string expiration_status { get; set; }
    public virtual object channel_id { get; set; }
    public virtual string course_url { get; set; }
}