namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class StockBackorderConfirmationLine
{
    public virtual object backorder_confirmation_id { get; set; }
    public virtual object picking_id { get; set; }
    public virtual bool to_backorder { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}