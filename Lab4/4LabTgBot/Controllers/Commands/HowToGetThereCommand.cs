using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using System.IO;

namespace _4LabTgBot.Controllers.Commands
{
    public class HowToGetThereCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "How to get there";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;

            await Client.SendTextMessageAsync(
                chatId,
                text: "вулиця Князя Романа, 5, Львів, Львівська область, 79000");
            await Client.SendLocationAsync(
                chatId,
                latitude: 49.83583333f,
                longitude: 24.01027778f);
        }
    }
    
}

