namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class FleetVehicleCostReport
{
    public virtual object company_id { get; set; }
    public virtual object vehicle_id { get; set; }
    public virtual string name { get; set; }
    public virtual object driver_id { get; set; }
    public virtual string fuel_type { get; set; }
    public virtual string date_start { get; set; }
    public virtual string vehicle_type { get; set; }
    public virtual double cost { get; set; }
    public virtual string cost_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}