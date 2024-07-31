namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class EventQuestion
{
    public virtual string title { get; set; }
    public virtual string question_type { get; set; }
    public virtual object event_type_id { get; set; }
    public virtual object event_id { get; set; }
    public virtual long[] answer_ids { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool once_per_order { get; set; }
    public virtual bool is_mandatory_answer { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}