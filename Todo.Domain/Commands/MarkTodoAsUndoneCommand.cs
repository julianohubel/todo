using System;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands

{
    public class MarkTodoAsUnDoneCommand : Contract<MarkTodoAsUnDoneCommand>, ICommand
    {
        public MarkTodoAsUnDoneCommand()
        {
            
        }

        public MarkTodoAsUnDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;            
        }

        public Guid Id { get; set; }
        public string User { get; set; }
    }

}
