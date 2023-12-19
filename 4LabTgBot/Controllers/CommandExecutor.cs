using _4LabTgBot.Controllers.Commands;
using Telegram.Bot.Types;

namespace _4LabTgBot.Controllers
{
    public class CommandExecutor : ITelegramUpdateListener
    {
        private List<ICommand> commands;
        public CommandExecutor()
        {
            commands = new List<ICommand>()
            {
                new StartCommand(),
                new SpecialtiesCommand(),
                new EducationalProgramsCommand(),
                new MilitaryDepartmentCommand(),
                new HowToGetThereCommand(),
                new OfficialSiteCommand(),
                new ExitCommand()
            };
        }
        public async Task GetUpdate(Update update)
        {
            Message msg = update.Message;
            ICommand searchCommand = commands.FirstOrDefault(command => command.Name == msg.Text);
            if (searchCommand != null)
            {
                await searchCommand.Execute(update);
            }
            else
                await new NotFoundCommand().Execute(update);
        }
    }
}
