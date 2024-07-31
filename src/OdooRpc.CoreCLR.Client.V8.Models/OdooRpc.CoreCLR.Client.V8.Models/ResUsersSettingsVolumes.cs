﻿namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class ResUsersSettingsVolumes
{
    public virtual object user_setting_id { get; set; }
    public virtual object partner_id { get; set; }
    public virtual object guest_id { get; set; }
    public virtual double volume { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}