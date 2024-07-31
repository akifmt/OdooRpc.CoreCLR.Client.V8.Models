namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AppointmentManageLeaves
{
    public virtual long[] appointment_resource_ids { get; set; }
    public virtual object calendar_id { get; set; }
    public virtual string leave_start_dt { get; set; }
    public virtual string leave_end_dt { get; set; }
    public virtual string reason { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}