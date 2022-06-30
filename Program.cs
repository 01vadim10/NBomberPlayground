// See https://aka.ms/new-console-template for more information

using NBomber.Contracts;
using NBomber.CSharp;

using var httpClient = new HttpClient();

var step = Step.Create("fetch_html_page", async context =>
{
    var response = await httpClient.GetAsync("https://nbomber.com");
    
    return response.IsSuccessStatusCode
        ? Response.Ok()
        : Response.Fail();
});

var scenario = ScenarioBuilder.CreateScenario("simple_http", step);

NBomberRunner
    .RegisterScenarios(scenario)
    .Run();