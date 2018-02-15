﻿using Aspose.Tasks.Saving;
using Aspose.Tasks.Visualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTasks.WorkingWithTaskConstraints
{
    class SetConstraintMustFinishOn
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project instance
            Project project1 = new Project(dataDir + "ConstraintMustFinishOn.mpp");

            // ExStart:SetConstraintMustFinishOn
            // Set constraint Must Finish On for task with Id 15
            Task interiorFixtures = project1.RootTask.Children.GetById(15);
            interiorFixtures.Set(Tsk.ConstraintType, ConstraintType.MustFinishOn);
            interiorFixtures.Set(Tsk.ConstraintDate, new DateTime(2017, 3, 1, 18, 0, 0));
                        
            // Save project as pdf
            SaveOptions options = new PdfSaveOptions();
            options.StartDate = project1.Get(Prj.StartDate);
            options.Timescale = Timescale.ThirdsOfMonths;
            project1.Save(dataDir + "project_MustFinishOn_out.pdf", options);
            // ExEnd:SetConstraintMustFinishOn
        }
    }
}
