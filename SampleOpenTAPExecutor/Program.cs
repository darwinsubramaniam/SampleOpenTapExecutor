using SampleOpenTAPExecutor;

Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Starting OpenTAP");

//SearchPlugin().Wait();

for (int i = 0; i < 50; i++)
{
    Console.WriteLine(i.ToString());
    SearchPlugin().Wait();
    var testplan = SampleTestPlanBuilder.GetTestPlan();
    var testPlanRunTask = testplan.ExecuteAsync();
    testPlanRunTask.Wait();
}

Task SearchPlugin()
{
    var pluginSearch = OpenTap.PluginManager.SearchAsync();

    pluginSearch.ContinueWith(x =>
    {
        var plugins = OpenTap.PluginManager.GetAllPlugins();
        
    });
    return pluginSearch;
}


