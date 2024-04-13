using System.Reflection;

namespace clpr;

internal class program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            var version = Assembly.GetEntryAssembly()?
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                .InformationalVersion
                .ToString();
            
            Console.WriteLine($"clpr v{version}");
            Console.WriteLine("----------------");
            Console.WriteLine("\nUsage");
            Console.WriteLine("  clpr <URL>");
            
        }

        RunCmd(string.Join(' ', args));
    }

    static void RunCmd(string cmd)
    {
        
    }

    static bool ChangeDlDir()
    {
        

        return true;
    }
}

