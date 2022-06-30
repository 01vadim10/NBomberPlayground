// See https://aka.ms/new-console-template for more information

using NBomber.Contracts;
using NBomber.CSharp;

Console.WriteLine("Hello, World!");

var step = Step.Create("step", async context =>
{
    await Task.Delay(TimeSpan.FromMilliseconds(500));
    return Response.Ok();
});

var scenario = ScenarioBuilder.CreateScenario("hello_world", step);

NBomberRunner
    .RegisterScenarios(scenario)
    .Run();