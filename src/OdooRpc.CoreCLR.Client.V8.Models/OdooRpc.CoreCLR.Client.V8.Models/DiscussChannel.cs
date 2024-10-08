﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DiscussChannel
{
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
    public virtual string name { get; set; }
    public virtual bool active { get; set; }
    public virtual string channel_type { get; set; }
    public virtual bool is_chat { get; set; }
    public virtual bool is_editable { get; set; }
    public virtual string default_display_mode { get; set; }
    public virtual string description { get; set; }
    public virtual string image_128 { get; set; }
    public virtual string avatar_128 { get; set; }
    public virtual string avatar_cache_key { get; set; }
    public virtual long[] channel_partner_ids { get; set; }
    public virtual long[] channel_member_ids { get; set; }
    public virtual long[] pinned_message_ids { get; set; }
    public virtual string sfu_channel_uuid { get; set; }
    public virtual string sfu_server_url { get; set; }
    public virtual long[] rtc_session_ids { get; set; }
    public virtual bool is_member { get; set; }
    public virtual long member_count { get; set; }
    public virtual string last_interest_dt { get; set; }
    public virtual long[] group_ids { get; set; }
    public virtual string uuid { get; set; }
    public virtual object group_public_id { get; set; }
    public virtual string invitation_url { get; set; }
    public virtual bool allow_public_upload { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual long[] subscription_department_ids { get; set; }
    public virtual double rating_last_value { get; set; }
    public virtual string rating_last_feedback { get; set; }
    public virtual string rating_last_image { get; set; }
    public virtual long rating_count { get; set; }
    public virtual double rating_avg { get; set; }
    public virtual string rating_avg_text { get; set; }
    public virtual double rating_percentage_satisfaction { get; set; }
    public virtual string rating_last_text { get; set; }
    public virtual string anonymous_name { get; set; }
    public virtual double duration { get; set; }
    public virtual bool livechat_active { get; set; }
    public virtual object livechat_channel_id { get; set; }
    public virtual object livechat_operator_id { get; set; }
    public virtual object chatbot_current_step_id { get; set; }
    public virtual long[] chatbot_message_ids { get; set; }
    public virtual object country_id { get; set; }
    public virtual object livechat_visitor_id { get; set; }
}