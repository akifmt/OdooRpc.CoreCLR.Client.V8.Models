namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SurveyUser_inputLine
{
    public virtual object user_input_id { get; set; }
    public virtual object survey_id { get; set; }
    public virtual object question_id { get; set; }
    public virtual object page_id { get; set; }
    public virtual long question_sequence { get; set; }
    public virtual bool skipped { get; set; }
    public virtual string answer_type { get; set; }
    public virtual string value_char_box { get; set; }
    public virtual double value_numerical_box { get; set; }
    public virtual long value_scale { get; set; }
    public virtual string value_date { get; set; }
    public virtual string value_datetime { get; set; }
    public virtual string value_text_box { get; set; }
    public virtual object suggested_answer_id { get; set; }
    public virtual object matrix_row_id { get; set; }
    public virtual double answer_score { get; set; }
    public virtual bool answer_is_correct { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}