// See https://aka.ms/new-console-template for more information
using DotNet8.StateAndTownshipDataFrame.Models;
using DotNet8.StateAndTownshipDataFrame.Services;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");
AppDbContext appDbContext = new AppDbContext();

var jsonStr = await File.ReadAllTextAsync("Data/Tbl_PlaceState.json");
var stateLst = JsonConvert.DeserializeObject<List<StateModel>>(jsonStr);
var stateDataLst = stateLst.Select(x=> new StateDataModel
{
    StateCode = x.StateCode,
    StateName = x.StateName,
}).ToList();
await appDbContext.State.AddRangeAsync(stateDataLst);
var result = await appDbContext.SaveChangesAsync();

Console.WriteLine(jsonStr);