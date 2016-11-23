﻿using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    class SetGeneralResourceProperties
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // Create project instance
            Project project = new Project();

            // ExStart:SetGeneralResourceProperties
            // Add resources
            Resource rsc1 = project.Resources.Add("Rsc");

            // Set resource properties, Resource properties are represented by static class Rsc
            rsc1.Set(Rsc.StandardRate, 15);
            rsc1.Set(Rsc.OvertimeRate, 20);
            // ExEnd:SetGeneralResourceProperties

            // Save project as XML
            project.Save(dataDir + "SetGeneralResourceProperties_out.xml", SaveFileFormat.XML);
        }
    }
}