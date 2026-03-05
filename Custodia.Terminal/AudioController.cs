using System;
using System.Media;
using System.Runtime.InteropServices;

namespace Custodia.Terminal;

public class AudioController
{
    /// <summary>
    /// Plays a WAV file safely, avoiding crashes on macOS. Code modified and found from Microsoft.Learn tutorials for
    /// soundplayer class and interopservices platform invoke:
    /// link #1: https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer?view=windowsdesktop-10.0
    /// link #2: https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/interop/how-to-use-platform-invoke-to-play-a-wave-file
    /// </summary>
    /// <param name="filePath">The relative path to the .wav file.</param>

    public void PlayGreeting(string filePath)
    {
        // Check if the application is running on Windows
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            try
            {
                // Suppress the compiler warning since machine is running windows
            #pragma warning disable CA1416
                using SoundPlayer player = new SoundPlayer(filePath);
                player.Play();  // Plays asynchronously so the application does not freeze
            #pragma warning restore CA1416
            }
            catch (Exception ex)
            {
                // Fallback if the user system has no audio device or the file is missing
                Console.WriteLine($"[System Notice] Audio playback failed: {ex.Message}");
            }
        }
        // Check if the application is running on macOS
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            // Safely bypass Windows API and print a debug message for own testing purposes
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("[Debug]: *Simulating voice greeting audio playback on Apple Silicon*");
            Console.ResetColor();
        }
    }
}