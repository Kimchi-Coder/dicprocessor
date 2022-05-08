// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
//
// app.MapGet("/", () => "Hello World!");
//
// app.Run();

using System.Xml;
using DicProcessor.XMLProcessor;

public class Test
{
    public static void Main()
    {
        Processor.LoadAndSave();
    }
}