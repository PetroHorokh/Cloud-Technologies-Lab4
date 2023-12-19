using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace _4LabTgBot.Controllers.Commands
{
    public class OfficialSiteCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "Офіційний сайт";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;
    
            await Client.SendTextMessageAsync(chatId, "https://lpnu.ua/imfn");

        }
    }
}
