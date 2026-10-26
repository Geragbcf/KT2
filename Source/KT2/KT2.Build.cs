// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class KT2 : ModuleRules
{
	public KT2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"KT2",
			"KT2/Variant_Platforming",
			"KT2/Variant_Platforming/Animation",
			"KT2/Variant_Combat",
			"KT2/Variant_Combat/AI",
			"KT2/Variant_Combat/Animation",
			"KT2/Variant_Combat/Gameplay",
			"KT2/Variant_Combat/Interfaces",
			"KT2/Variant_Combat/UI",
			"KT2/Variant_SideScrolling",
			"KT2/Variant_SideScrolling/AI",
			"KT2/Variant_SideScrolling/Gameplay",
			"KT2/Variant_SideScrolling/Interfaces",
			"KT2/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
