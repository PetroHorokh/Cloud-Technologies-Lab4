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

        public string Name => "Освітні програми";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;

           
            await Client.SendTextMessageAsync(
                chatId,
                text: "Бакалавр, магістр, аспірант.");

           
        }
    }
}
