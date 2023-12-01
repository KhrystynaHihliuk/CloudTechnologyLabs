
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace _4LabTgBot.Controllers.Commands
{
    public class StartCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "/start";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;

            // Send the initial message
            await Client.SendTextMessageAsync(
                chatId,
                text: "Choose an option:",
                replyMarkup: GetChessboardMainMenuKeyboard());

            // You can include additional functionality here if needed
        }

        // Helper method to create the main menu keyboard
        private ReplyKeyboardMarkup GetChessboardMainMenuKeyboard()
        {
            return new ReplyKeyboardMarkup(new List<KeyboardButton[]>
            {
        new KeyboardButton[] { new KeyboardButton("Military department"), new KeyboardButton("Educational programs"), new KeyboardButton("Specialties") },
        new KeyboardButton[] { new KeyboardButton("How to get there"), new KeyboardButton("Official site") },
        new KeyboardButton[] { new KeyboardButton("Exit") },
            })
            {
                ResizeKeyboard = true
            };
        }


    }
}

