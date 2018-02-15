/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.ImportingAndExporting
{
    public class ReadXMLFileWithMultipleProjects
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

            // ExStart:ReadXMLFileWithMultipleProjects
            PrimaveraXmlReadingOptions options = new PrimaveraXmlReadingOptions();
            options.ProjectUid = 4557;
            // Returns project with special Uid
            Project project = new Project(dataDir + "Project.xml", options); 
            // ExEnd:ReadXMLFileWithMultipleProjects
        }
    }
}