namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class GamificationKarmaRank
{
    public virtual string image_1920 { get; set; }
    public virtual string image_1024 { get; set; }
    public virtual string image_512 { get; set; }
    public virtual string image_256 { get; set; }
    public virtual string image_128 { get; set; }
    public virtual string name { get; set; }
    public virtual string description { get; set; }
    public virtual string description_motivational { get; set; }
    public virtual long karma_min { get; set; }
    public virtual long[] user_ids { get; set; }
    public virtual long rank_users_count { get; set; }
    public virtual long id { get; set; }
    public virtual string display_name { get; set; }
    public virtual object create_uid { get; set; }
    public virtual string create_date { get; set; }
    public virtual object write_uid { get; set; }
    public virtual string write_date { get; set; }
}