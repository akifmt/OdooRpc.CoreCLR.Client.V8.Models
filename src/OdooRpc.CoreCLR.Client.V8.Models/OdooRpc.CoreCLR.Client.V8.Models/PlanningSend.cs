namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class PlanningSend
{
    public virtual string start_datetime { get; set; }
    public virtual string end_datetime { get; set; }
    public virtual bool include_unassigned { get; set; }
    public virtual string note { get; set; }
    public virtual long[] employee_ids { get; set; }
    public virtual long[] slot_ids { get; set; }
    public virtual long[] employees_no_email { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}