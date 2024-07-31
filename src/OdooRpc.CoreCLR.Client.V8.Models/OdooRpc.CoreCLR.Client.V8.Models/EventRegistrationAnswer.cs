namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class EventRegistrationAnswer
{
    public virtual object question_id { get; set; }
    public virtual object registration_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object event_id { get; set; }
    public virtual string question_type { get; set; }
    public virtual object value_answer_id { get; set; }
    public virtual string value_text_box { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}