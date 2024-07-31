namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class IrProfile
{
    public virtual string create_date { get; set; }
    public virtual string session { get; set; }
    public virtual string name { get; set; }
    public virtual double duration { get; set; }
    public virtual string init_stack_trace { get; set; }
    public virtual string sql { get; set; }
    public virtual long sql_count { get; set; }
    public virtual string traces_async { get; set; }
    public virtual string traces_sync { get; set; }
    public virtual string qweb { get; set; }
    public virtual long entry_count { get; set; }
    public virtual string speedscope { get; set; }
    public virtual string speedscope_url { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}