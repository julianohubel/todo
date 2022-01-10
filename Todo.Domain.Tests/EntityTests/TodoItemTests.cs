using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using System;
using Todo.Domain.Entities;

namespace todo.domain.tests.EntityTests
{
    [TestClass]
    public class TodoItemTest
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);        
        private readonly TodoItem _validTodo =  new TodoItem("Todo", "user", DateTime.Now);


        [TestMethod]
        public void Given_a_new_todo_it_shoud_not_be_done()
        {                        
            Assert.IsFalse(_validTodo.Done);
        }
   
    }
}
