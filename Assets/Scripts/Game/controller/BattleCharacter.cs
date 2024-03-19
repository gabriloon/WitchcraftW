using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class BattleCharacter : MonoBehaviour
    {   
        [SerializeField]private string charID;
         [SerializeField]private string enemyTag;
        private Animator _playerAnim;
        public CharacterBaseInfo charInfo;
        private GameObject _enemyObject;
        private float _targetDistance = float.MaxValue;
        private float _charAttackDistance = 1.0f;
        private float _charMoveSpeed = 1.0f;
        void Start()
        {
            _playerAnim = this.GetComponent<Animator>();
            charInfo = DefaultData.GetInitialCharacterValue(charID);
            _charMoveSpeed = charInfo.speed;

            FindTarget();
        }

        void Update()
        {
            if(charInfo.hp<=0)
            {
                _playerAnim.SetTrigger("Dead");
                charInfo.atk = 0;
                Destroy(gameObject, 1f);
            }
            else
            {
                if(_enemyObject == null)
                {
                    FindTarget();
                }
                else
                {
                    if(_charAttackDistance<_targetDistance)MoveTarget();
                    else
                    {
                        _playerAnim.SetTrigger("Attack");  
                    }
                }    
            }
        }

        private void FindTarget()
        {
            GameObject[] enemyObjects = GameObject.FindGameObjectsWithTag(enemyTag);
            if (enemyObjects.Length <= 0)
            {
                _enemyObject = null;
                Debug.Log(charID+"승리");
                _playerAnim.SetTrigger("Victory");  
                return;
            }
            Vector2 playerPosition = this.transform.position;

            GameObject closestEnemyObject = null;
            _targetDistance = float.MaxValue;

            foreach (GameObject enemyObject in enemyObjects)
            {
                Vector2 enemyPosition = enemyObject.transform.position;
                float distance = Vector2.Distance(playerPosition, enemyPosition);
                if (distance < _targetDistance)
                {
                    _targetDistance = distance;
                    closestEnemyObject = enemyObject;
                }
            }
            _enemyObject = closestEnemyObject;
        }
        private void MoveTarget()
        {
            _playerAnim.SetTrigger("Walk");  
            transform.position = Vector2.MoveTowards(transform.position, _enemyObject.transform.position, _charMoveSpeed * Time.deltaTime);
            _targetDistance = Vector2.Distance(transform.position, _enemyObject.transform.position);
        }

        public void Attack()
        {
            if (_enemyObject == null) return;
            _enemyObject.GetComponent<BattleCharacter>().charInfo.hp -= charInfo.atk;
        }
    }
}