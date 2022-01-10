using System;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class UpdateTodoCommand : Contract<UpdateTodoCommand> , ICommand
    {
        public UpdateTodoCommand()
        {
            
        }
        
        public UpdateTodoCommand(Guid id, string title, string user)
        {
            Id = id;
            Title = title;
            User = user;
            

            Requires()
            .IsGreaterThan(Title, 3, "Title", "Title is invalid")
            .IsGreaterThan(User, 3 , "User", "User is invalid"); 
            
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string User { get; set; }

    }
}