using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskyApp.Handler;
using Task = TaskyApp.Model.Task;

namespace TaskyApp.ViewModel
{
    public class TechnicianTaskPageVM
    {
        private TaskHandler _taskHandler;

        public ObservableCollection<Task> UndoneTaskCollection { get; set; }
        
        public TechnicianTaskPageVM()
        {
            _taskHandler = new TaskHandler();
            // UndoneTaskCollection = _taskHandler.RetrievedUndoneTaskCollection();
        }


    }
}
