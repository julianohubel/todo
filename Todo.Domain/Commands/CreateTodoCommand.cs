using System;
using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{    
    public class CreateTodoCommand : Contract<ICommand>, ICommand
    {

        public CreateTodoCommand(){
            Validate();
        }

        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = Title;
            User = user;
            Date = date;

            Validate();                                 
        }

        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }       

        private void Validate()
        {
            Requires()
            .IsGreaterThan(Title, 3, "Title", "Title is invalid")
            .IsGreaterThan(User, 3 , "User", "User is invalid"); 
        }

    }
}