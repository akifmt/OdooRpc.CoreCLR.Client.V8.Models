namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class Im_livechatChannelRule
{
    public virtual string regex_url { get; set; }
    public virtual string action { get; set; }
    public virtual long auto_popup_timer { get; set; }
    public virtual object chatbot_script_id { get; set; }
    public virtual bool chatbot_only_if_no_operator { get; set; }
    public virtual object channel_id { get; set; }
    public virtual long[] country_ids { get; set; }
    public virtual long sequence { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}