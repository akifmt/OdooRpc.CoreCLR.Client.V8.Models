namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class TimerTimer
{
    public virtual string timer_start { get; set; }
    public virtual string timer_pause { get; set; }
    public virtual bool is_timer_running { get; set; }
    public virtual string res_model { get; set; }
    public virtual long res_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}