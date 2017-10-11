using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;


public class AIHelpBuildPostProcessor
{

	[PostProcessBuildAttribute(1)]
	public static void OnPostProcessBuild(BuildTarget target, string path)
	{
		if (target == BuildTarget.iOS)
		{
			// Read.
			string projectPath = PBXProject.GetPBXProjectPath(path);
			PBXProject project = new PBXProject();
			project.ReadFromString(File.ReadAllText(projectPath));
			string targetName = PBXProject.GetUnityTargetName();
			string projectTarget = project.TargetGuidByName(targetName);

			AddFrameworks(project, projectTarget);

			// Write.
			File.WriteAllText(projectPath, project.WriteToString());
		}
	}

	static void AddFrameworks(PBXProject project, string target)
	{
		// Frameworks (webkit and sqlite)
		project.AddFrameworkToProject(target, "WebKit.framework", false);
		project.AddFrameworkToProject(target, "libsqlite3.tbd", false);

		// Add `-ObjC` to "Other Linker Flags".
		project.AddBuildProperty(target, "OTHER_LDFLAGS", "-ObjC");
	}
}
