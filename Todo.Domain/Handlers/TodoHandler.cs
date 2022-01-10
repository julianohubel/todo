using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracts;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandler :     
     IHandler<CreateTodoCommand>
    {        
        private readonly ITodoRepository _repository;

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateTodoCommand command)
        {
            if(!command.IsValid)
                return new GenericCommandResult(false, "Failed Request", command.Notifications);

            var todoItem = new TodoItem(command.Title, command.User, command.Date);

            _repository.Create(todoItem);

            return new GenericCommandResult(true, "Request Success", todoItem);

        }
    }
}