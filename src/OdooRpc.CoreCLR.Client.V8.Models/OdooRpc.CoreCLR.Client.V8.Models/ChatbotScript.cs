﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ChatbotScript
{
    public virtual string name { get; set; }
    public virtual object source_id { get; set; }
    public virtual string image_1920 { get; set; }
    public virtual string image_1024 { get; set; }
    public virtual string image_512 { get; set; }
    public virtual string image_256 { get; set; }
    public virtual string image_128 { get; set; }
    public virtual string title { get; set; }
    public virtual bool active { get; set; }
    public virtual long[] script_step_ids { get; set; }
    public virtual object operator_partner_id { get; set; }
    public virtual long livechat_channel_count { get; set; }
    public virtual string first_step_warning { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}