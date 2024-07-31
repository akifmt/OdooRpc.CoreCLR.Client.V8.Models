namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockBackorderConfirmation
{
    public virtual long[] pick_ids { get; set; }
    public virtual bool show_transfers { get; set; }
    public virtual long[] backorder_confirmation_line_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}