// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "KT2GameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class AKT2GameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	AKT2GameMode();
};



