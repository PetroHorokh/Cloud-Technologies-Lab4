using Telegram.Bot.Types;

namespace _4LabTgBot.Controllers
{
    public interface ITelegramUpdateListener
    {
        Task GetUpdate(Update update);
    }
}