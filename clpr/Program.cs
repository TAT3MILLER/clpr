using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
using YoutubeDLSharp;
using YoutubeDLSharp.Metadata;
using YoutubeDLSharp.Options;

namespace clpr;

internal class Program
{
    private Startup settings = new Startup();
    static async Task Main(string[] args)
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
            Console.WriteLine("  clpr <URL>                        ~Input a yt URL to clip the audio");
            Console.WriteLine("  clpr change-dir <New Directory>   ~Change download directory");
            
            
        }
        
        await RunCmd(string.Join(' ', args));
    }

    static async Task RunCmd(string cmd)
    {
        
        var ytdl = new YoutubeDL
        {
            YoutubeDLPath = Directory.GetCurrentDirectory()+"\\Binaries\\yt-dlp.exe",
            FFmpegPath = Directory.GetCurrentDirectory()+"\\Binaries\\ffmpeg.exe",
            OutputFolder = Environment.ExpandEnvironmentVariables("%userprofile%\\downloads\\"),
            OutputFileTemplate = "%(title)s.%(ext)s"
        };
        Console.WriteLine(ytdl.OutputFolder);
        Console.WriteLine(File.Exists(ytdl.FFmpegPath) + "ffmpeg");
        Console.WriteLine(File.Exists(ytdl.YoutubeDLPath)+"ytdl");
        Console.WriteLine();
        var res = await ytdl.RunAudioDownload("https://www.youtube.com/watch?v=kpwNjdEPz7E", AudioConversionFormat.Mp3);
        Console.WriteLine(res.Success);
        Console.WriteLine(res.Success ? "Download Finished" : "Download Failed");
    }


    static bool CheckExist()
    {
        var exists = false;

        string curFile = @"c:\temp\";

        return exists;
    }
}

