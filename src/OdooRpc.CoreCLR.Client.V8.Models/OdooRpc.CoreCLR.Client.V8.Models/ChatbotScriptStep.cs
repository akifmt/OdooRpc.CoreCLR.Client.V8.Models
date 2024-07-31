namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ChatbotScriptStep
{
    public virtual string message { get; set; }
    public virtual long sequence { get; set; }
    public virtual object chatbot_script_id { get; set; }
    public virtual string step_type { get; set; }
    public virtual long[] answer_ids { get; set; }
    public virtual long[] triggering_answer_ids { get; set; }
    public virtual bool is_forward_operator_child { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}