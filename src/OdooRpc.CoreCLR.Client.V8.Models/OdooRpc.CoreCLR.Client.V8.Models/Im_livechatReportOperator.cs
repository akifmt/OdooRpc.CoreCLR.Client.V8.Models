namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Im_livechatReportOperator
{
    public virtual object partner_id { get; set; }
    public virtual object livechat_channel_id { get; set; }
    public virtual long nbr_channel { get; set; }
    public virtual object channel_id { get; set; }
    public virtual string start_date { get; set; }
    public virtual double time_to_answer { get; set; }
    public virtual double duration { get; set; }
    public virtual double rating { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
}