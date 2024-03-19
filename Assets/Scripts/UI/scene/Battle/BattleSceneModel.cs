using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;

namespace GameUI
{
    public class BattleSceneModel
    {
        private List<CharacterPlacement> _characterPlacements;
        private StageInfo _stageInfo;

        public BattleSceneModel()
        {
            _characterPlacements = new List<CharacterPlacement>
            {
                new CharacterPlacement(Character.ControlledCharacterID.CONTROLL_CHAR_00, Character.BattlePosition.FRONT_LEFT),
                new CharacterPlacement(Character.ControlledCharacterID.CONTROLL_CHAR_02, Character.BattlePosition.MID_LEFT),
            };

            _stageInfo = DefaultData.GetStageInfo(Stage.STAGE_1_1);

        }


        public BattleSceneModel(List<CharacterPlacement> characterPlacements, StageInfo stageInfo)
        {
            _characterPlacements = characterPlacements;
            _stageInfo = stageInfo;
        }
        public StageInfo GetStageInfo()
        {
            return _stageInfo;
        }
    }
}
