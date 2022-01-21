using System;
using Discord;
using Discord.Gateway;

namespace Unblock
{
    class backend
    {
        public static void Message()
        {


            DiscordSocketClient client = new DiscordSocketClient(new DiscordSocketConfig()
            {
                // fun fact: intents are required for bots as of v8, which Anarchy uses by default.
                Intents = DiscordGatewayIntent.Guilds | DiscordGatewayIntent.GuildMessages
            });
            //replace the appliction ID(933939424872513556) , and the other thingy (tBqksTt50M3EZL7P-OYwH-FjhdzGIX7jiOh34Xfi9MKXGmOf3EMj1MSBCOAKCaYHmvS) wiht your own

            DiscordDefaultWebhook defaultWebhook = (DiscordDefaultWebhook)client.GetWebhook(933939424872513556, "tBqksTt50M3EZL7P-OYwH-FjhdzGIX7jiOh34Xfi9MKXGmOf3EMj1MSBCOAKCaYHmvS");
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("MESSAGE: ");
                Console.ForegroundColor= ConsoleColor.Green;
                string Message = Console.ReadLine();
                if(Message == "")
                {
                    Console.WriteLine("Cannot Send Empty");
                }
                else
                {
                    defaultWebhook.SendMessage(Message, null, new DiscordWebhookProfile()
                    {
                        Username = "your mum",
                        AvatarUrl = "https://emoji.gg/assets/emoji/8587_fat_guy_in_space.png"

                    });
                }
              
            

            }

            //email password...
            client.User.ChangeProfile(new UserProfileUpdate()
            {
                Username = "username",
                Password = "password" // password must be provided when changing username, email, discriminator or password
            });
            client.User.Update();

            //badges...
            client.User.ChangeProfile(new UserProfileUpdate()
            {
                Biography = "fuck you!"
            });

            //settings...
            client.User.ChangeSettings(new UserSettingsProperties()
            {
                Theme = DiscordTheme.Light,
                DeveloperMode = true,
                Language = DiscordLanguage.Spanish,
                CustomStatus = new CustomStatus()
                {
                    Text = "skiding jews",
                }
            });
        }
    }
}
