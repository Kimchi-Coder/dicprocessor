// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
//
// app.MapGet("/", () => "Hello World!");
//
// app.Run();

using System.Xml;
using DicProcessor.XMLProcessor;

public class Program
{
    public static async Task Main()
    {
        await Processor.LoadAndSave();
    }
}