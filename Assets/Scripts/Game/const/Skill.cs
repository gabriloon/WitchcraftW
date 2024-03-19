
namespace Game
{
    public class Skill
    {
        public string id;
        public string name;
        public string description;
        public string effectType;
        public string attackType;
        public int consumeAmount;
        public int power;
        public float criticalRate;
        public bool isFree;

        override public string ToString()
        {
            return "id=" + id + " name=" + name + " description=";
        }
    }

    public interface SkillID
    {
        public static string[] CHAR1_SKILLS = new string[] { PHYS_00 };
        // public static string[] SHIHO_SKILLS = new string[] { FLAM_00, HEAL_00, FLAM_03, BUFF_ATK_00, FLAM_01, HEAL_03, FLAM_04, BUFF_ATK_01, RCVR_00, AD_RSST_01, RCVR_01, RM_RSST_01, HEAL_05, RCVR_02 };
        public const string COMMON = "skill_9999";
        // 물리
        public const string PHYS_00 = "skill_0000";
        // 화염
        public const string FLAM_00 = "skill_0100";
        // 빙결
        public const string FREZ_00 = "skill_0200";

        // 전격
        public const string ELEC_00 = "skill_0300";
        //치유
        public const string HEAL_00 = "skill_0700";
        //물리 버프
        public const string BUFF_ATK_00 = "skill_0900";
        //방어 버프
        public const string BUFF_DFS_00 = "skill_1000";
        //마법 버프
        public const string BUFF_MAG_00 = "skill_1100";
        public const string BUFF_MAG_01 = "skill_1101";
        //확률 버프
        public const string BUFF_HIT_00 = "skill_1200";
    }
}