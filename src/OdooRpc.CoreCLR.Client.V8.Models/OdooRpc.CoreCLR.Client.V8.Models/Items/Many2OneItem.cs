using System.Text.Json.Nodes;

namespace OdooRpc.CoreCLR.Client.V8.Models.Items;

public partial class Many2OneItem
{
    public Many2OneItem(object item)
    {
        try
        {
            string? itemStr = item.ToString();
            if (itemStr is null) return;

            var jsonArr = JsonArray.Parse(itemStr);
            if (jsonArr is null) return;

            var arr = jsonArr.AsArray();
            if (arr is null || arr.Count != 2) return;

            long? id = (long?)arr[0];
            this.id = id is not null ? id.Value : 0;
            string? name = (string?)arr[1];
            this.name = name is not null ? name : "";
        }
        catch { }
    }

    public long id { get; set; }
    public string name { get; set; } = string.Empty;
}