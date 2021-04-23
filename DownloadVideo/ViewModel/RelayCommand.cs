using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DownloadVideo.ViewModel
{
    /// <summary>
    /// A class that relay Icommand class
    /// </summary>
    class RelayCommand : ICommand
    {
        #region private member
        /// <summary>
        /// The action to run
        /// </summary>
        public Action<object> execute;
        #endregion

        #region Constructs
        /// <summary>
        /// Default constructer
        /// </summary>
        /// <param name="execute"></param>
        public RelayCommand(Action<object> execute)
        {
            this.execute = execute;
        }
        #endregion

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// determines whether the command can excute in its current status
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// called when the command is inovked <see cref="execute"/>
        /// </summary>
        /// <param name="parameter">Ignore it </param>
        public  void Execute(object parameter) =>  execute.Invoke(parameter);
    }
}
