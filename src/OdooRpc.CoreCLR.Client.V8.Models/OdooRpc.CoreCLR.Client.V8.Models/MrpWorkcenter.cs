﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class MrpWorkcenter
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
    public virtual object company_id { get; set; }
    public virtual string effective_date { get; set; }
    public virtual object maintenance_team_id { get; set; }
    public virtual object technician_user_id { get; set; }
    public virtual long[] maintenance_ids { get; set; }
    public virtual long maintenance_count { get; set; }
    public virtual long maintenance_open_count { get; set; }
    public virtual long expected_mtbf { get; set; }
    public virtual long mtbf { get; set; }
    public virtual long mttr { get; set; }
    public virtual string estimated_next_failure { get; set; }
    public virtual string latest_failure_date { get; set; }
    public virtual string analytic_distribution { get; set; }
    public virtual long analytic_precision { get; set; }
    public virtual object resource_id { get; set; }
    public virtual object resource_calendar_id { get; set; }
    public virtual string tz { get; set; }
    public virtual string name { get; set; }
    public virtual double time_efficiency { get; set; }
    public virtual bool active { get; set; }
    public virtual string code { get; set; }
    public virtual string note { get; set; }
    public virtual double default_capacity { get; set; }
    public virtual long sequence { get; set; }
    public virtual long color { get; set; }
    public virtual object currency_id { get; set; }
    public virtual double costs_hour { get; set; }
    public virtual double time_start { get; set; }
    public virtual double time_stop { get; set; }
    public virtual long[] routing_line_ids { get; set; }
    public virtual bool has_routing_lines { get; set; }
    public virtual long[] order_ids { get; set; }
    public virtual long workorder_count { get; set; }
    public virtual long workorder_ready_count { get; set; }
    public virtual long workorder_progress_count { get; set; }
    public virtual long workorder_pending_count { get; set; }
    public virtual long workorder_late_count { get; set; }
    public virtual long[] time_ids { get; set; }
    public virtual string working_state { get; set; }
    public virtual double blocked_time { get; set; }
    public virtual double productive_time { get; set; }
    public virtual double oee { get; set; }
    public virtual double oee_target { get; set; }
    public virtual long performance { get; set; }
    public virtual double workcenter_load { get; set; }
    public virtual long[] alternative_workcenter_ids { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual long[] capacity_ids { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] costs_hour_account_ids { get; set; }
    public virtual long[] employee_ids { get; set; }
    public virtual string employee_costs_hour { get; set; }
    public virtual long[] equipment_ids { get; set; }
}