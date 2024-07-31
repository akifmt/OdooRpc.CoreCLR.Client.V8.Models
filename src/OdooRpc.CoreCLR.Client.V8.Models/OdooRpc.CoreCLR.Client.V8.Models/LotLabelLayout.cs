namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class LotLabelLayout
{
    public virtual long[] move_line_ids { get; set; }
    public virtual string label_quantity { get; set; }
    public virtual string print_format { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}