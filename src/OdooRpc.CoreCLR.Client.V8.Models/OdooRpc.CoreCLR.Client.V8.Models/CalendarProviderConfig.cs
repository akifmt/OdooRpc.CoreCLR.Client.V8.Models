namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class CalendarProviderConfig
{
    public virtual string external_calendar_provider { get; set; }
    public virtual string cal_client_id { get; set; }
    public virtual string cal_client_secret { get; set; }
    public virtual bool cal_sync_paused { get; set; }
    public virtual string microsoft_outlook_client_identifier { get; set; }
    public virtual string microsoft_outlook_client_secret { get; set; }
    public virtual bool microsoft_outlook_sync_paused { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}