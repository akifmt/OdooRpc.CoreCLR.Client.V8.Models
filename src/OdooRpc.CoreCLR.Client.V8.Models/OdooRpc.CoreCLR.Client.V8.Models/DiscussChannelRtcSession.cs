namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DiscussChannelRtcSession
{
    public virtual object channel_member_id { get; set; }
    public virtual object channel_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object guest_id { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool is_screen_sharing_on { get; set; }
    public virtual bool is_camera_on { get; set; }
    public virtual bool is_muted { get; set; }
    public virtual bool is_deaf { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
}