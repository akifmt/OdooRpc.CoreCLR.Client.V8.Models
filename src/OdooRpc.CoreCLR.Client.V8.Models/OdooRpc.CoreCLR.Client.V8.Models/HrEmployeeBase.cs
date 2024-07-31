﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class HrEmployeeBase
{
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual long color { get; set; }
    public virtual object department_id { get; set; }
    public virtual bool member_of_department { get; set; }
    public virtual object job_id { get; set; }
    public virtual string job_title { get; set; }
    public virtual object company_id { get; set; }
    public virtual object address_id { get; set; }
    public virtual string work_phone { get; set; }
    public virtual string phone { get; set; }
    public virtual string mobile_phone { get; set; }
    public virtual string work_email { get; set; }
    public virtual string email { get; set; }
    public virtual object work_contact_id { get; set; }
    public virtual object work_location_id { get; set; }
    public virtual object user_id { get; set; }
    public virtual bool share { get; set; }
    public virtual object resource_id { get; set; }
    public virtual object resource_calendar_id { get; set; }
    public virtual object parent_id { get; set; }
    public virtual object coach_id { get; set; }
    public virtual string tz { get; set; }
    public virtual string hr_presence_state { get; set; }
    public virtual string last_activity { get; set; }
    public virtual string last_activity_time { get; set; }
    public virtual string hr_icon_display { get; set; }
    public virtual bool show_hr_icon_display { get; set; }
    public virtual string im_status { get; set; }
    public virtual bool newly_hired { get; set; }
    public virtual long[] goal_ids { get; set; }
    public virtual long[] badge_ids { get; set; }
    public virtual bool has_badges { get; set; }
    public virtual long[] direct_badge_ids { get; set; }
    public virtual long child_all_count { get; set; }
    public virtual long department_color { get; set; }
    public virtual long child_count { get; set; }
    public virtual bool has_slots { get; set; }
}