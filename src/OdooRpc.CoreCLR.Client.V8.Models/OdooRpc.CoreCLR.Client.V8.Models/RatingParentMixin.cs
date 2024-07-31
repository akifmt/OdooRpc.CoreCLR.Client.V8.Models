namespace OdooRpc.CoreCLR.Client.V8.Models;

public partial class RatingParentMixin
{
    public virtual long[] rating_ids { get; set; }
    public virtual long rating_percentage_satisfaction { get; set; }
    public virtual long rating_count { get; set; }
    public virtual double rating_avg { get; set; }
    public virtual double rating_avg_percentage { get; set; }
}