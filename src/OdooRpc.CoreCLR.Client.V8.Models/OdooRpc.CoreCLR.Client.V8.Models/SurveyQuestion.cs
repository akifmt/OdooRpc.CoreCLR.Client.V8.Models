﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SurveyQuestion
{
    public virtual string title { get; set; }
    public virtual string description { get; set; }
    public virtual string question_placeholder { get; set; }
    public virtual string background_image { get; set; }
    public virtual string background_image_url { get; set; }
    public virtual object survey_id { get; set; }
    public virtual string scoring_type { get; set; }
    public virtual long sequence { get; set; }
    public virtual bool session_available { get; set; }
    public virtual bool is_page { get; set; }
    public virtual long[] question_ids { get; set; }
    public virtual string questions_selection { get; set; }
    public virtual long random_questions_count { get; set; }
    public virtual object page_id { get; set; }
    public virtual string question_type { get; set; }
    public virtual bool is_scored_question { get; set; }
    public virtual bool has_image_only_suggested_answer { get; set; }
    public virtual double answer_numerical_box { get; set; }
    public virtual string answer_date { get; set; }
    public virtual string answer_datetime { get; set; }
    public virtual double answer_score { get; set; }
    public virtual bool save_as_email { get; set; }
    public virtual bool save_as_nickname { get; set; }
    public virtual long[] suggested_answer_ids { get; set; }
    public virtual string matrix_subtype { get; set; }
    public virtual long[] matrix_row_ids { get; set; }
    public virtual long scale_min { get; set; }
    public virtual long scale_max { get; set; }
    public virtual string scale_min_label { get; set; }
    public virtual string scale_mid_label { get; set; }
    public virtual string scale_max_label { get; set; }
    public virtual bool is_time_limited { get; set; }
    public virtual bool is_time_customized { get; set; }
    public virtual long time_limit { get; set; }
    public virtual bool comments_allowed { get; set; }
    public virtual string comments_message { get; set; }
    public virtual bool comment_count_as_answer { get; set; }
    public virtual bool validation_required { get; set; }
    public virtual bool validation_email { get; set; }
    public virtual long validation_length_min { get; set; }
    public virtual long validation_length_max { get; set; }
    public virtual double validation_min_float_value { get; set; }
    public virtual double validation_max_float_value { get; set; }
    public virtual string validation_min_date { get; set; }
    public virtual string validation_max_date { get; set; }
    public virtual string validation_min_datetime { get; set; }
    public virtual string validation_max_datetime { get; set; }
    public virtual string validation_error_msg { get; set; }
    public virtual bool constr_mandatory { get; set; }
    public virtual string constr_error_msg { get; set; }
    public virtual long[] user_input_line_ids { get; set; }
    public virtual long[] triggering_question_ids { get; set; }
    public virtual long[] allowed_triggering_question_ids { get; set; }
    public virtual bool is_placed_before_trigger { get; set; }
    public virtual long[] triggering_answer_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}