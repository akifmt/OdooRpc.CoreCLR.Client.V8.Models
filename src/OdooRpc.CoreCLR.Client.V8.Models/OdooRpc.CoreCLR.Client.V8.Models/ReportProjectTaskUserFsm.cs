﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ReportProjectTaskUserFsm
{
    public virtual string name { get; set; }
    public virtual long[] user_ids { get; set; }
    public virtual string create_date { get; set; }
    public virtual string date_assign { get; set; }
    public virtual string date_end { get; set; }
    public virtual string date_deadline { get; set; }
    public virtual string date_last_stage_update { get; set; }
    public virtual object project_id { get; set; }
    public virtual double working_days_close { get; set; }
    public virtual double working_days_open { get; set; }
    public virtual double delay_endings_days { get; set; }
    public virtual long nbr { get; set; }
    public virtual double working_hours_open { get; set; }
    public virtual double working_hours_close { get; set; }
    public virtual string priority { get; set; }
    public virtual string state { get; set; }
    public virtual bool is_closed { get; set; }
    public virtual object company_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object stage_id { get; set; }
    public virtual object task_id { get; set; }
    public virtual bool active { get; set; }
    public virtual long[] tag_ids { get; set; }
    public virtual object parent_id { get; set; }
    public virtual long[] personal_stage_type_ids { get; set; }
    public virtual object milestone_id { get; set; }
    public virtual bool message_is_follower { get; set; }
    public virtual long[] dependent_ids { get; set; }
    public virtual string description { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual double allocated_hours { get; set; }
    public virtual double effective_hours { get; set; }
    public virtual double remaining_hours { get; set; }
    public virtual double remaining_hours_percentage { get; set; }
    public virtual double progress { get; set; }
    public virtual double overtime { get; set; }
    public virtual double total_hours_spent { get; set; }
    public virtual double subtask_effective_hours { get; set; }
    public virtual string planned_date_begin { get; set; }
    public virtual long[] user_skill_ids { get; set; }
    public virtual object sale_line_id { get; set; }
    public virtual object sale_order_id { get; set; }
    public virtual double remaining_hours_so { get; set; }
    public virtual string partner_zip { get; set; }
    public virtual string partner_city { get; set; }
    public virtual string partner_street { get; set; }
    public virtual string partner_street2 { get; set; }
    public virtual object partner_country_id { get; set; }
    public virtual object partner_state_id { get; set; }
    public virtual string invoice_status { get; set; }
}