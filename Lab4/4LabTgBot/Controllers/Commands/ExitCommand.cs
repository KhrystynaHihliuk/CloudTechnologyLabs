using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace _4LabTgBot.Controllers.Commands
{
    public class ExitCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "Exit";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;


            await Client.SendTextMessageAsync(
                chatId,
                text: "Exiting... Thank you for using the bot!",
                replyMarkup: new ReplyKeyboardRemove());

        }
    }
}
