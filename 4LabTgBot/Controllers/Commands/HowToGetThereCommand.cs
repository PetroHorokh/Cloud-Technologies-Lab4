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

        public string Name => "Як добратись";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;

            await Client.SendTextMessageAsync(
                chatId,
                text: "вул. Митрополита Андрея 5, 4-й н.к., кім. 212а");
        }
    }
}

