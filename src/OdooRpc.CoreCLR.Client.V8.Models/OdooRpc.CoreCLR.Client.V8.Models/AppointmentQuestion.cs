namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class AppointmentQuestion
{
    public virtual long sequence { get; set; }
    public virtual object appointment_type_id { get; set; }
    public virtual string name { get; set; }
    public virtual string placeholder { get; set; }
    public virtual bool question_required { get; set; }
    public virtual string question_type { get; set; }
    public virtual long[] answer_ids { get; set; }
    public virtual long[] answer_input_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}