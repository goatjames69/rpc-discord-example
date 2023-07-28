using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Using DiscordRPC is mandatory, install it from Nuget Packages
using DiscordRPC;

namespace rpc_example
{
    internal class discordrpc
    {
        public static DiscordRpcClient client;
        public static void Initialize()
        {
            // Create Application in https://discord.com/developers/applications and copy Application ID
            client = new DiscordRpcClient("your application id");
            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "NAME",
                Assets = new Assets()
                {
                    LargeImageKey = "image link",
                    LargeImageText = "Example Discord RPC",
                    SmallImageKey = "image link",
                    SmallImageText = "N/A",
                },
                Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() { Label = "Discord", Url = "https://discord.gg/goatjames/" }
                },
                Timestamps = Timestamps.Now
            });
        }
    }

}
//by goat james