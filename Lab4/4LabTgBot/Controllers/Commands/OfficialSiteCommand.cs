using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace _4LabTgBot.Controllers.Commands
{
    public class OfficialSiteCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "Official site";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;

    
            await Client.SendTextMessageAsync(chatId, "https://lpnu.ua/");

        }
    }
}
