namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class TimerMixin
{
    public virtual string timer_start { get; set; }
    public virtual string timer_pause { get; set; }
    public virtual bool is_timer_running { get; set; }
    public virtual long[] user_timer_id { get; set; }
    public virtual bool display_timer_start_primary { get; set; }
    public virtual bool display_timer_stop { get; set; }
    public virtual bool display_timer_pause { get; set; }
    public virtual bool display_timer_resume { get; set; }
}