using CommandLine;
using CommandLine.Text;
using System.Collections.Generic;

namespace bnetlauncher
{
    class Options
    {
        [Option('i', "ignore",
            Default = false,
            HelpText = "Ignore unknown game value.")]
        bool? Ignore { get; set; }

        [Option('l', "log",
            Default = false,
            HelpText = "Enables the Log file.")]
        bool? Log { get; set; }

        [Option('t', "timeout",
            Default = 15,
            HelpText = "Time in seconds to wait for the game to start.")]
        int? Timeout { get; set; }
    }
}
