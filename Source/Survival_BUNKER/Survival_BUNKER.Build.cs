// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Survival_BUNKER : ModuleRules
{
	public Survival_BUNKER(ReadOnlyTargetRules Target) : base(Target)
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
			"Survival_BUNKER",
			"Survival_BUNKER/Variant_Horror",
			"Survival_BUNKER/Variant_Horror/UI",
			"Survival_BUNKER/Variant_Shooter",
			"Survival_BUNKER/Variant_Shooter/AI",
			"Survival_BUNKER/Variant_Shooter/UI",
			"Survival_BUNKER/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
