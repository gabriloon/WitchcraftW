using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    [SerializeField]
    public class CharacterBaseInfo
    {
        public string characterId;
        public string name;
        public Character.Sex sex;
        public int level;
        public int hp;
        public int mp;
        public int maxHP;
        public int maxMP;
        public int atk;
        public int vit;
        public int agi;
        public int luck;
        public int speed;
        public Character.Job job;
        public Character.Statistic statistic;
        public List<string> skill;
        public string toString()
        {
            return "characterId=" + characterId + ", name=" + name + ", level=" + level + ", hp=" + hp + ", maxHP=" + maxHP + ", mp=" + mp + ", maxMP=" + maxMP + ", atk=" + atk + ", vit=" + vit +
                     ", agi=" + agi + ", luck=" + luck + ", skill=" + skill + ", speed=" + speed + ", job=" + job + ", statistic=" + statistic;
        }
    }
}