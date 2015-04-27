using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.BusinessLayer.Contracts;

namespace TestProject.BusinessLayer.Handlers
{
    /// <summary>
    /// Abstract class for all command handlers
    /// </summary>
    public abstract class CommandHandlerBase<TRequest, TResult> : IHandler
        where TRequest : ICommand
        where TResult : CommandResult
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public CommandResult Execute(ICommand command)
        {
            return ExecuteCommand((TRequest)command);
        }

        /// <summary>
        /// The method that executes the command
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected abstract TResult ExecuteCommand(TRequest command);

    }

    public interface IHandler
    {
        CommandResult Execute(ICommand command);
    }
}
