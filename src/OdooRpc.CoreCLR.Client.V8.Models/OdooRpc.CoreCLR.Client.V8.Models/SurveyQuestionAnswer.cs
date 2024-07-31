namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SurveyQuestionAnswer
{
    public virtual object question_id { get; set; }
    public virtual object matrix_question_id { get; set; }
    public virtual string question_type { get; set; }
    public virtual long sequence { get; set; }
    public virtual string scoring_type { get; set; }
    public virtual string value { get; set; }
    public virtual string value_image { get; set; }
    public virtual string value_image_filename { get; set; }
    public virtual string value_label { get; set; }
    public virtual bool is_correct { get; set; }
    public virtual double answer_score { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}