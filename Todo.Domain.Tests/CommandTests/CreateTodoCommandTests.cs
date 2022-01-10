using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using System;

namespace todo.domain.tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);        
        private readonly CreateTodoCommand _validCommand =  new CreateTodoCommand("Titulo", "Tarefa", DateTime.Now);


        [TestMethod]
        public void Given_an_invalid_command()
        {            
            Assert.IsFalse(_invalidCommand.IsValid);
        }

        [TestMethod]
        public void Given_a_valid_command()
        {            
            Assert.IsTrue(_validCommand.IsValid);
        }
    }
}
