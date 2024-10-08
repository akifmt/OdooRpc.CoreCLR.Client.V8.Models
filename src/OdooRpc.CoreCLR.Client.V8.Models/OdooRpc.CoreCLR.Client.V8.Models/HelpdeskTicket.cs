﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HelpdeskTicket
{
    public virtual string duration_tracking { get; set; }
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
    public virtual double rating_last_value { get; set; }
    public virtual string rating_last_feedback { get; set; }
    public virtual string rating_last_image { get; set; }
    public virtual long rating_count { get; set; }
    public virtual double rating_avg { get; set; }
    public virtual string rating_avg_text { get; set; }
    public virtual double rating_percentage_satisfaction { get; set; }
    public virtual string rating_last_text { get; set; }
    public virtual object campaign_id { get; set; }
    public virtual object source_id { get; set; }
    public virtual object medium_id { get; set; }
    public virtual string email_cc { get; set; }
    public virtual string access_url { get; set; }
    public virtual string access_token { get; set; }
    public virtual string access_warning { get; set; }
    public virtual string name { get; set; }
    public virtual object team_id { get; set; }
    public virtual bool use_sla { get; set; }
    public virtual string team_privacy_visibility { get; set; }
    public virtual string description { get; set; }
    public virtual bool active { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual object company_id { get; set; }
    public virtual long color { get; set; }
    public virtual string kanban_state { get; set; }
    public virtual string kanban_state_label { get; set; }
    public virtual string legend_blocked { get; set; }
    public virtual string legend_done { get; set; }
    public virtual string legend_normal { get; set; }
    public virtual long[] domain_user_ids { get; set; }
    public virtual object user_id { get; set; }
    public virtual object[] properties { get; set; }
    public virtual object partner_id { get; set; }
    public virtual long[] partner_ticket_ids { get; set; }
    public virtual long partner_ticket_count { get; set; }
    public virtual long partner_open_ticket_count { get; set; }
    public virtual string partner_name { get; set; }
    public virtual string partner_email { get; set; }
    public virtual string partner_phone { get; set; }
    public virtual object commercial_partner_id { get; set; }
    public virtual bool closed_by_partner { get; set; }
    public virtual string priority { get; set; }
    public virtual object stage_id { get; set; }
    public virtual bool fold { get; set; }
    public virtual string date_last_stage_update { get; set; }
    public virtual string ticket_ref { get; set; }
    public virtual string assign_date { get; set; }
    public virtual double assign_hours { get; set; }
    public virtual string close_date { get; set; }
    public virtual double close_hours { get; set; }
    public virtual long open_hours { get; set; }
    public virtual long[] sla_ids { get; set; }
    public virtual long[] sla_status_ids { get; set; }
    public virtual bool sla_reached_late { get; set; }
    public virtual bool sla_reached { get; set; }
    public virtual string sla_deadline { get; set; }
    public virtual double sla_deadline_hours { get; set; }
    public virtual bool sla_fail { get; set; }
    public virtual bool sla_success { get; set; }
    public virtual bool use_credit_notes { get; set; }
    public virtual bool use_coupons { get; set; }
    public virtual bool use_product_returns { get; set; }
    public virtual bool use_product_repairs { get; set; }
    public virtual bool use_rating { get; set; }
    public virtual bool is_partner_email_update { get; set; }
    public virtual bool is_partner_phone_update { get; set; }
    public virtual double first_response_hours { get; set; }
    public virtual double avg_response_hours { get; set; }
    public virtual string oldest_unanswered_customer_message_date { get; set; }
    public virtual long answered_customer_message_count { get; set; }
    public virtual double total_response_hours { get; set; }
    public virtual bool display_extra_info { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}