
    using System.Threading.Tasks;
    using Telegram.Bot;
    using Telegram.Bot.Types;
    using Telegram.Bot.Types.ReplyMarkups;

    namespace _4LabTgBot.Controllers.Commands
    {
        public class MilitaryDepartmentCommand : ICommand
        {
            public TelegramBotClient Client => Bot.GetTelegramBot().Result;

            public string Name => "Military department";

            public async Task Execute(Update update)
            {
                long chatId = update.Message.Chat.Id;

               
                await Client.SendTextMessageAsync(
                    chatId,
                    text: "Present🧑‍🚀");

               
            }
        }
    }


