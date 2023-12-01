using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace _4LabTgBot.Controllers.Commands
{
    public class EducationalProgramsCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "Educational programs";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;

           
            await Client.SendTextMessageAsync(
                chatId,
                text: "Choose an educational program:",
                replyMarkup: GetEducationalProgramsInlineKeyboard());

           
        }

        
        private InlineKeyboardMarkup GetEducationalProgramsInlineKeyboard()
        {
            return new InlineKeyboardMarkup(new List<InlineKeyboardButton[]>
            {
                new InlineKeyboardButton[] { InlineKeyboardButton.WithUrl("(122) Computer Science", "https://lpnu.ua/iknie") },
                new InlineKeyboardButton[] { InlineKeyboardButton.WithUrl("(121) Software engineering", "https://lpnu.ua/sites/default/files/2021/program/15946/121-mag-2021.PDF") },
                new InlineKeyboardButton[] { InlineKeyboardButton.WithUrl("(124) System analysis", "https://old.lpnu.ua/en/education/majors/ICSIT/6.124.00.00/8/2020/en/full") },
                new InlineKeyboardButton[] { InlineKeyboardButton.WithUrl("(125) Cyber security", "https://lpnu.ua/sites/default/files/2021/program/12427/onp-2020-kiberbezpeka.pdf") },
                new InlineKeyboardButton[] { InlineKeyboardButton.WithUrl("(126) Information systems and technologies", "https://ism.lpnu.ua/en/content/126-information-systems-and-technologies-phd") },
              
            });
        }
    }
}
