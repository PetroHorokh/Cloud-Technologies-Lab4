
    using System.Threading.Tasks;
    using Telegram.Bot;
    using Telegram.Bot.Types;
    using Telegram.Bot.Types.ReplyMarkups;

    namespace _4LabTgBot.Controllers.Commands
    {
        public class MilitaryDepartmentCommand : ICommand
        {
            public TelegramBotClient Client => Bot.GetTelegramBot().Result;

            public string Name => "Військова кафедра";

            public async Task Execute(Update update)
            {
                long chatId = update.Message.Chat.Id;

               
                await Client.SendTextMessageAsync(
                    chatId,
                    text: "Присутня\ud83e\uddd1\u200d\ud83d\ude80.");

               
            }
        }
    }


