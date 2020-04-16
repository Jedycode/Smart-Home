using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Smart_Home_System.Model.ScriptsManager;

namespace Smart_Home_System.ViewModel
{
    class ScriptsListViewModel
    {
        public ObservableCollection<ScriptModel> ScriptsList { get; set; }
        public ScriptsListViewModel()
        {
            ScriptsList = new ObservableCollection<ScriptModel>();
            ScriptsList.Add(new ScriptModel { Name = "Script 1", Detail ="Some Text"});
            ScriptsList.Add(new ScriptModel { Name = "Script 2", Detail = "Some Text" });
            ScriptsList.Add(new ScriptModel { Name = "Script 3", Detail = "Some Text" });
        }
    }
}
