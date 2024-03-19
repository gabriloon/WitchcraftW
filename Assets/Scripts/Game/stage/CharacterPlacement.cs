using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class CharacterPlacement
    {
        private string _characterId { get; set; }
        private Character.BattlePosition _position { get; set; }

        public CharacterPlacement(string characterId, Character.BattlePosition position)
        {
            _characterId = characterId;
            _position = position;
        }
        public string GetCharacterID()
        {
            return _characterId;
        }
        public Character.BattlePosition GetCharacterPos()
        {
            return _position;
        }


    }
}
