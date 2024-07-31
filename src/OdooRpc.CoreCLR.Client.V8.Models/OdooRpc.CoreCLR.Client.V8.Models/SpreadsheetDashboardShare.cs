namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SpreadsheetDashboardShare
{
    public virtual string spreadsheet_binary_data { get; set; }
    public virtual string spreadsheet_data { get; set; }
    public virtual string thumbnail { get; set; }
    public virtual string spreadsheet_snapshot { get; set; }
    public virtual long[] spreadsheet_revision_ids { get; set; }
    public virtual string current_revision_uuid { get; set; }
    public virtual object dashboard_id { get; set; }
    public virtual string excel_export { get; set; }
    public virtual string access_token { get; set; }
    public virtual string full_url { get; set; }
    public virtual string name { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}