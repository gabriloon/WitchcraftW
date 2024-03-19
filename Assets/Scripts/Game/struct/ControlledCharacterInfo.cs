using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game
{
    [SerializeField]
    public class ControlledCharacterInfo : CharacterBaseInfo
    {
        public int exp;
        // public bool isSupporter;
        //배틀 캐릭터와 서포터 캐릭터 이렇게 분류해서 파티에 넣으면 재밌을거 같다.
        public ControlledCharacterInfo GetClone()
        {
            var info = new ControlledCharacterInfo();
            info.characterId = characterId;
            info.name = this.name;
            info.sex = this.sex;
            info.level = this.level;
            info.hp = this.hp;
            info.maxHP = this.maxHP;
            info.mp = this.mp;
            info.maxMP = this.maxMP;
            info.exp = this.exp;
            info.atk = this.atk;
            info.vit = this.vit;
            info.agi = this.agi;
            info.luck = this.luck;
            info.speed = this.speed;

            info.job = this.job;
            if (this.skill != null) info.skill = new List<string>(this.skill);

            return info;
        }

        override public string ToString()
        {
            return "[ColleagueStatusInfo name= " + name + " level = " + level + " remainExp = " + exp + " fullHP: " + maxHP + " fullMP: " + maxMP +
            " ATK: " + atk + " VIT: " + vit + agi + " LUCK: " + luck + "]";
        }
    }
}