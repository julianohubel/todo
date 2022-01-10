using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using System;
using Todo.Domain.Handlers;
using todo.domain.tests.Repoitories;
using Todo.Domain.Commands.Contracts;

namespace todo.domain.tests.HandlerTEsts
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);        
        private readonly CreateTodoCommand _validCommand =  new CreateTodoCommand("Titulo", "Tarefa", DateTime.Now);

        [TestMethod]
        public void Given_an_invalid_command()
        {            
             var handler =  new TodoHandler(new FakeTodoRepository());
             GenericCommandResult res = (GenericCommandResult)handler.Handle(_invalidCommand);    

             Assert.AreEqual(false, res.Success);     
        }        

        [TestMethod]
        public void Given_an_valid_command()
        {            
             var handler =  new TodoHandler(new FakeTodoRepository());
             GenericCommandResult res = (GenericCommandResult)handler.Handle(_validCommand);    

             Assert.AreEqual(true, res.Success);      
        }        
    }
}
