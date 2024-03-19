using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;

public class DefaultData
{
    private static Dictionary<string, CharacterBaseInfo> characterInfoDictionary = new Dictionary<string, CharacterBaseInfo>
    {
        {
            Character.ControlledCharacterID.CONTROLL_CHAR_00,
            new CharacterBaseInfo
            {
                characterId = Character.ControlledCharacterID.CONTROLL_CHAR_00,
                level = 1,
                name = "CollegeStudent",
                sex = Character.Sex.FEMALE,
                maxHP = 100,
                maxMP = 50,
                hp = 30,  // Initial HP can be set differently if needed
                mp = 50,  // Initial MP can be set differently if needed
                atk = 8,
                vit = 20,
                agi = 5,
                luck = 5,
                speed = 3,
                job = Character.Job.TANKER,
                skill = new List<string> { SkillID.BUFF_DFS_00 },
                statistic = Character.Statistic.LIGHT
            }
        },
        {
            Character.ControlledCharacterID.CONTROLL_CHAR_01,
            new CharacterBaseInfo
            {
                characterId = Character.ControlledCharacterID.CONTROLL_CHAR_01,
                name = "Cat",
                sex = Character.Sex.NONE,
                maxHP = 30,
                maxMP = 80,
                hp = 30,  // Initial HP can be set differently if needed
                mp = 80,  // Initial MP can be set differently if needed
                atk = 12,
                vit = 10,
                agi = 5,
                luck = 5,
                speed = 5,
                job = Character.Job.WARRIOR,
                skill = new List<string> { SkillID.PHYS_00 },
                statistic = Character.Statistic.FIRE
            }
        },
        {
            Character.EnemyID.ENEMY_00,
            new CharacterBaseInfo
            {
                characterId = Character.EnemyID.ENEMY_00,
                name = "Skeleton",
                sex = Character.Sex.NONE,
                maxHP = 20,
                maxMP = 10,
                hp = 20,  // Initial HP can be set differently if needed
                mp = 10,  // Initial MP can be set differently if needed
                atk = 20,
                vit = 5,
                agi = 5,
                luck = 5,
                speed = 3,
                job = Character.Job.WARRIOR,
                skill = new List<string> { SkillID.PHYS_00 },
                statistic = Character.Statistic.DARK
            }
        },
    };

    public static CharacterBaseInfo GetInitialCharacterValue(string id)
    {
        if (characterInfoDictionary.ContainsKey(id))
        {
            return characterInfoDictionary[id];
        }
        else
        {
            return null;
        }
    }

    public static Dictionary<string, StageInfo> StageInfoMaster = new Dictionary<string, StageInfo>
    {
        {
            Stage.STAGE_1_1,
            new StageInfo(
                new List<CharacterPlacement>
                {
                    new CharacterPlacement(Character.EnemyID.ENEMY_00, Character.BattlePosition.ENEMY_FRONT_LEFT)
                },
                Background.DOWNTOWN,
                "bgm_01",
                3,
                new List<string>{"Reward1", "Reward2"}
            )
        },
    };

    public static StageInfo GetStageInfo(string stageID)
    {
        if (StageInfoMaster.TryGetValue(stageID, out StageInfo stageInfo))
        {
            return stageInfo;
        }
        else
        {
            return null;
        }
    }
}
