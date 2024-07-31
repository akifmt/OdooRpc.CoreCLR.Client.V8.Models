namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class RentalOrderWizard
{
    public virtual object order_id { get; set; }
    public virtual long[] rental_wizard_line_ids { get; set; }
    public virtual string status { get; set; }
    public virtual bool is_late { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool has_tracked_lines { get; set; }
    public virtual bool has_lines_missing_stock { get; set; }
}