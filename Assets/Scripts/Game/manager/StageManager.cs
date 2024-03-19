using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class StageManager
    {
        public static Dictionary<Character.BattlePosition, Vector3> characterPositions = new Dictionary<Character.BattlePosition, Vector3>
        {
            {Character.BattlePosition.FRONT_LEFT,new Vector3(-400.0f,-400.0f,0.0f)},
            {Character.BattlePosition.FRONT_RIGHT,new Vector3(-400.0f,-200.0f,0.0f)},
            {Character.BattlePosition.MID_LEFT,new Vector3(-600.0f,-400.0f,0.0f)},
            {Character.BattlePosition.MID_RIGHT,new Vector3(-600.0f,-200.0f,0.0f)},
            {Character.BattlePosition.BACK_LEFT,new Vector3(-800.0f,-400.0f,0.0f)},
            {Character.BattlePosition.BACK_RIGHT,new Vector3(-800.0f,-200.0f,0.0f)},
            {Character.BattlePosition.ENEMY_FRONT_LEFT,new Vector3(200.0f,-400.0f,0.0f)},
            {Character.BattlePosition.ENEMY_FRONT_RIGHT,new Vector3(200.0f,-200.0f,0.0f)},
            {Character.BattlePosition.ENEMY_MID_LEFT,new Vector3(400.0f,-400.0f,0.0f)},
            {Character.BattlePosition.ENEMY_MID_RIGHT,new Vector3(400.0f,-200.0f,0.0f)},
            {Character.BattlePosition.ENEMY_BACK_LEFT,new Vector3(600.0f,-400.0f,0.0f)},
            {Character.BattlePosition.ENEMY_BACK_RIGHT,new Vector3(600.0f,-200.0f,0.0f)},
        };
    }
}