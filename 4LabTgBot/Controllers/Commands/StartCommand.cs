
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
                text: "Виберіть опцію:",
                replyMarkup: GetChessboardMainMenuKeyboard());

            // You can include additional functionality here if needed
        }

        // Helper method to create the main menu keyboard
        private ReplyKeyboardMarkup GetChessboardMainMenuKeyboard()
        {
            return new ReplyKeyboardMarkup(new List<KeyboardButton[]>
            {
        new KeyboardButton[] { new KeyboardButton("Спеціальності"), new KeyboardButton("Освітні програми"), new KeyboardButton("Військова кафедра") },
        new KeyboardButton[] { new KeyboardButton("Як добратись"), new KeyboardButton("Офіційний сайт") },
        new KeyboardButton[] { new KeyboardButton("Назад🔙") },
            })
            {
                ResizeKeyboard = true
            };
        }


    }
}

