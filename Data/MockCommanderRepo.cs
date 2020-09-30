using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command { Id = 0, HowTo = "Boil and egg", Line = "Boild water", Platform = "Kettle" },
                new Command { Id = 1, HowTo = "Boil and egg1", Line = "Boild water1", Platform = "Kettle1" },
                new Command { Id = 2, HowTo = "Boil and egg2", Line = "Boild water2", Platform = "Kettle2" }
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boild water", Platform = "Kettle" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}