using Telegram.Bot;

    namespace _4LabTgBot
    {
        public class Bot
        {
        //https://api.telegram.org/bot6899495667:AAEUaYqVveJeqnDTBSsyEaNjw1U3woFVhvs/setWebhook?url=https://71e6-178-212-111-194.ngrok.io
        //https://api.telegram.org/bot6899495667:AAEUaYqVveJeqnDTBSsyEaNjw1U3woFVhvs/setWebhook?url=ambotkhrystyna.azurewebsites.net
        private static TelegramBotClient? client { get; set; }
            public static async Task<TelegramBotClient> GetTelegramBot()
            {
                if (client != null)
                {
                    return client;
                }
                client = new TelegramBotClient("6899495667:AAEUaYqVveJeqnDTBSsyEaNjw1U3woFVhvs");
                string hook = "ambotkhrystyna.azurewebsites.net";
                await client.SetWebhookAsync(hook);
                return client;
            }
        }
    }

