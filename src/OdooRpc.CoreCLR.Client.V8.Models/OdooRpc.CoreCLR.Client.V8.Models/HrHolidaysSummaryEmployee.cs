namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrHolidaysSummaryEmployee
{
    public virtual string date_from { get; set; }
    public virtual long[] emp { get; set; }
    public virtual string holiday_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}