﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class SurveyUser_input
{
    public virtual long[] activity_ids { get; set; }
    public virtual string activity_state { get; set; }
    public virtual object activity_user_id { get; set; }
    public virtual object activity_type_id { get; set; }
    public virtual string activity_type_icon { get; set; }
    public virtual string activity_date_deadline { get; set; }
    public virtual string my_activity_date_deadline { get; set; }
    public virtual string activity_summary { get; set; }
    public virtual string activity_exception_decoration { get; set; }
    public virtual string activity_exception_icon { get; set; }
    public virtual object activity_calendar_event_id { get; set; }
    public virtual bool message_is_follower { get; set; }
    public virtual long[] message_follower_ids { get; set; }
    public virtual long[] message_partner_ids { get; set; }
    public virtual long[] message_ids { get; set; }
    public virtual bool has_message { get; set; }
    public virtual bool message_needaction { get; set; }
    public virtual long message_needaction_counter { get; set; }
    public virtual bool message_has_error { get; set; }
    public virtual long message_has_error_counter { get; set; }
    public virtual long message_attachment_count { get; set; }
    public virtual long[] rating_ids { get; set; }
    public virtual long[] website_message_ids { get; set; }
    public virtual bool message_has_sms_error { get; set; }
    public virtual object survey_id { get; set; }
    public virtual string scoring_type { get; set; }
    public virtual string start_datetime { get; set; }
    public virtual string end_datetime { get; set; }
    public virtual string deadline { get; set; }
    public virtual string state { get; set; }
    public virtual bool test_entry { get; set; }
    public virtual object last_displayed_page_id { get; set; }
    public virtual bool is_attempts_limited { get; set; }
    public virtual long attempts_limit { get; set; }
    public virtual long attempts_count { get; set; }
    public virtual long attempts_number { get; set; }
    public virtual bool survey_time_limit_reached { get; set; }
    public virtual string access_token { get; set; }
    public virtual string invite_token { get; set; }
    public virtual object partner_id { get; set; }
    public virtual string email { get; set; }
    public virtual string nickname { get; set; }
    public virtual long[] user_input_line_ids { get; set; }
    public virtual long[] predefined_question_ids { get; set; }
    public virtual double scoring_percentage { get; set; }
    public virtual double scoring_total { get; set; }
    public virtual bool scoring_success { get; set; }
    public virtual bool survey_first_submitted { get; set; }
    public virtual bool is_session_answer { get; set; }
    public virtual bool question_time_limit_reached { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual object slide_id { get; set; }
    public virtual object slide_partner_id { get; set; }
}