using Telegram.Bot;

    namespace _4LabTgBot
    {
        public class Bot
        {
        private static TelegramBotClient? client { get; set; }
            public static async Task<TelegramBotClient> GetTelegramBot()
            {
                if (client != null)
                {
                    return client;
                }
                client = new TelegramBotClient("6943013536:AAHraQao63YgOQ8EFJ853Yui_epWrPIBr38");
                string hook = "lab4clouds.azurewebsites.net";
                await client.SetWebhookAsync(hook);
                return client;
            }
        }
    }

