using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace todo.domain.tests.Repoitories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {            
        }

        public void Update(TodoItem todo)
        {         
        }
    }
}