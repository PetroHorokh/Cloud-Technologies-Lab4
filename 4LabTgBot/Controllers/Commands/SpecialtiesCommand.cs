using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace _4LabTgBot.Controllers.Commands
{
    public class SpecialtiesCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "Спеціальності";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;


            await Client.SendTextMessageAsync(
                chatId,
                text: "(105) Прикладна фізика та наноматеріали; " +
                      "\n(113) Прикладна математика та інформатика,Фінансовий інжиніринг; " +
                      "\n(291) Міжнародні відносини,суспільні комунікаційні та регіональні студії(Міжнарожна інформація).");


        }
    }
}
