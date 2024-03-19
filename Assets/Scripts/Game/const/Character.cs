namespace Game
{
    public class Character
    {
        //[JsonConverter(typeof(StringEnumConverter))]

        public enum Sex
        {
            NONE,
            MALE,
            FEMALE,
        }

        public enum Job
        {
            TANKER,
            WIZARD,
            WARRIOR,
            SNIPER,
            ASSASSIN,
            SUPPORTER
        }

        public enum Statistic
        {
            LIGHT, 
            DARK, 
            GROUND, 
            FIRE, 
            WATER,
            MACHINE, 
            WIND
        }
        public enum AbnormalStatus
        {
            NONE,
            PARALYZE, //마비
            POISON,//중독
        }
        public enum BattlePosition
        {
            FRONT_LEFT, FRONT_RIGHT,
            MID_LEFT,  MID_RIGHT,
            BACK_LEFT,  BACK_RIGHT,
            ENEMY_FRONT_LEFT,ENEMY_FRONT_RIGHT,
            ENEMY_MID_LEFT,  ENEMY_MID_RIGHT,
            ENEMY_BACK_LEFT,  ENEMY_BACK_RIGHT,
        }


        public enum BattleAction
        {
            COMMAND, //커맨드 선택에 따라 행동
            ATK,     //물리 스킬 위주
            MAG,     //마법 스킬 위주
            HEAL,    //치유 스킬 위주
            BUFF     //버프 및 디버프 스킬 위주
        }

        public interface EnemyID
        {
            public const string ENEMY_00 = "Skeleton";
        }
        public interface ControlledCharacterID
        {
            public const string CONTROLL_CHAR_ROOT = "BattleScene/Character/ControlledCharacter";
            public const string CONTROLL_CHAR_00 = "CollegeStudent/CollegeStudent";
            public const string CONTROLL_CHAR_01 = "Pet Cats pack/";
            public const string CONTROLL_CHAR_02 = "Wizard";
        }
    }
}