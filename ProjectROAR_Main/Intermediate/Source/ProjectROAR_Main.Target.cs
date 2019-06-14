using UnrealBuildTool;

public class ProjectROAR_MainTarget : TargetRules
{
	public ProjectROAR_MainTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectROAR_Main");
	}
}
