namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ChatbotScriptAnswer
{
    public virtual string name { get; set; }
    public virtual long sequence { get; set; }
    public virtual string redirect_link { get; set; }
    public virtual object script_step_id { get; set; }
    public virtual object chatbot_script_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}