namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SpreadsheetMixin
{
    public virtual string spreadsheet_binary_data { get; set; }
    public virtual string spreadsheet_data { get; set; }
    public virtual string thumbnail { get; set; }
    public virtual string spreadsheet_snapshot { get; set; }
    public virtual long[] spreadsheet_revision_ids { get; set; }
    public virtual string current_revision_uuid { get; set; }
}