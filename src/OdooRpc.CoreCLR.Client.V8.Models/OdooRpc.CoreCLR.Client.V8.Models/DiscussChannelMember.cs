namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class DiscussChannelMember
{
    public virtual object partner_id { get; set; }
    public virtual object guest_id { get; set; }
    public virtual bool is_self { get; set; }
    public virtual object channel_id { get; set; }
    public virtual string custom_channel_name { get; set; }
    public virtual object fetched_message_id { get; set; }
    public virtual object seen_message_id { get; set; }
    public virtual long message_unread_counter { get; set; }
    public virtual string fold_state { get; set; }
    public virtual string custom_notifications { get; set; }
    public virtual string mute_until_dt { get; set; }
    public virtual bool is_pinned { get; set; }
    public virtual string unpin_dt { get; set; }
    public virtual string last_interest_dt { get; set; }
    public virtual string last_seen_dt { get; set; }
    public virtual long[] rtc_session_ids { get; set; }
    public virtual object rtc_inviting_session_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}