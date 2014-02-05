using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Project
    {
        partial void TotalTaskHours_Compute(ref int result)
        {
            result = this.ProjectTasks.Sum(t => t.EstimatedHours);
        }

        partial void TotalAdditionalCosts_Compute(ref decimal result)
        {
            result = this.AdditionalCosts.Sum(c => c.Amount);
        }
    }
}
