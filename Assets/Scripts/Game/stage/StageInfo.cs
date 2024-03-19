using System.Collections.Generic;

namespace Game
{
    public class StageInfo
    {
        public List<CharacterPlacement> monsterPlacements { get; set; }
        public string backgroundID;
        public string musicID;
        public int clearRemoveEnemy;
        //public string clearCondition;
        public List<string> rewardsID; 

        public StageInfo(List<CharacterPlacement> monsterPlacements, string backgroundID, string musicID, int clearRemoveEnemy, List<string> rewardsID)
        {
            this.monsterPlacements = monsterPlacements;
            this.backgroundID = backgroundID;
            this.musicID = musicID;
            this.clearRemoveEnemy = clearRemoveEnemy;
            this.rewardsID = rewardsID;
        }
    }
}
