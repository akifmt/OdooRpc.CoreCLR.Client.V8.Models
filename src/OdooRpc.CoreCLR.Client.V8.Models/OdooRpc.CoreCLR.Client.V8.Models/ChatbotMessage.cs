namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ChatbotMessage
{
    public virtual object mail_message_id { get; set; }
    public virtual object discuss_channel_id { get; set; }
    public virtual object script_step_id { get; set; }
    public virtual object user_script_answer_id { get; set; }
    public virtual string user_raw_answer { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}