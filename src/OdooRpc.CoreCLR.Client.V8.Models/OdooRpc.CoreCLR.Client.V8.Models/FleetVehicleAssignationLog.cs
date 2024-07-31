namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class FleetVehicleAssignationLog
{
    public virtual object vehicle_id { get; set; }
    public virtual object driver_id { get; set; }
    public virtual string date_start { get; set; }
    public virtual string date_end { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object driver_employee_id { get; set; }
    public virtual long attachment_number { get; set; }
}