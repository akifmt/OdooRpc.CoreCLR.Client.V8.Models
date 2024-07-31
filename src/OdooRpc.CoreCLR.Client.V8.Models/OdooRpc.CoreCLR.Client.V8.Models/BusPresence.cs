namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class BusPresence
{
    public virtual object user_id { get; set; }
    public virtual string last_poll { get; set; }
    public virtual string last_presence { get; set; }
    public virtual string status { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object guest_id { get; set; }
}