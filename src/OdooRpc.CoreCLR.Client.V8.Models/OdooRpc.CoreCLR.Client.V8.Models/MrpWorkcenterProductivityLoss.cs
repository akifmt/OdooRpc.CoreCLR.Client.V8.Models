namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpWorkcenterProductivityLoss
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool manual { get; set; }
    public virtual object loss_id { get; set; }
    public virtual string loss_type { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}