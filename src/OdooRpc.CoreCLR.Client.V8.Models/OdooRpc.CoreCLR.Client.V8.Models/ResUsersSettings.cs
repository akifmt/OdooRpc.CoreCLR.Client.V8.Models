namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResUsersSettings
{
    public virtual object user_id { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
    public virtual bool is_discuss_sidebar_category_channel_open { get; set; }
    public virtual bool is_discuss_sidebar_category_chat_open { get; set; }
    public virtual string push_to_talk_key { get; set; }
    public virtual bool use_push_to_talk { get; set; }
    public virtual long voice_active_duration { get; set; }
    public virtual long[] volume_settings_ids { get; set; }
    public virtual string homemenu_config { get; set; }
    public virtual string livechat_username { get; set; }
    public virtual long[] livechat_lang_ids { get; set; }
}