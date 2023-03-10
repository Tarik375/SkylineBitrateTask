// See https://aka.ms/new-console-template for more information
using skyline;
using System.Text.Json;
using static skyline.obj.CalculateBitrateClass;

var dataJson = File.ReadAllText("dataJson.json");
var vendor = JsonSerializer.Deserialize<Vendor>(dataJson);
Console.WriteLine("--------------------------------");

Console.WriteLine(vendor.Device);
Console.WriteLine(vendor.Model);
Console.WriteLine(vendor.Nics[0].Description);
Console.WriteLine(vendor.Nics[0].Mac);
Console.WriteLine((vendor.Nics[0].Timestamp).ToString("o"));
Console.WriteLine(vendor.Nics[0].Rx);
Console.WriteLine(vendor.Nics[0].Tx);
Console.WriteLine(CalculateBitrate(vendor.Nics[0].Rx));
Console.WriteLine("--------------------------------");