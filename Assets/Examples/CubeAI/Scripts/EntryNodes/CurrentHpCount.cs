﻿using Plugins.xNodeUtilityAi.AbstractNodes;
using Plugins.xNodeUtilityAi.Framework;

namespace Examples.CubeAI.Scripts.EntryNodes {
    public class CurrentHpCount : EntryIntNode {

        protected override int ValueProvider(AbstractAIComponent context) {
            CubeAIComponent cubeAiComponent = (CubeAIComponent) context;
            return cubeAiComponent.CubeEntity.CurrentHp;
        }
        
    }
}