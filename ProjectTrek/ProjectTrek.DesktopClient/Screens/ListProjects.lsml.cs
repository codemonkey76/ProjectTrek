using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class ListProjects
    {
        partial void CreateNewProject_Execute()
        {
            this.Projects.AddNew();
            this.FindControl("Projects_SelectedItem_Code").Focus();
        }

        partial void CloseProject_Execute()
        {
            this.Projects.SelectedItem.Closed = true;
        }

        partial void ReopenProject_Execute()
        {
            this.Projects.SelectedItem.Closed = false;
        }

        partial void CloseProject_CanExecute(ref bool result)
        {
            result = !this.Projects.SelectedItem.Closed;
        }

        partial void ReopenProject_CanExecute(ref bool result)
        {
            result = this.Projects.SelectedItem.Closed;
        }
    }
}
