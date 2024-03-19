using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;

namespace GameUI
{
    public class BattleScenePresenter : ScenePresenter
    {
        private BattleSceneView _sceneView;
        private BattleSceneModel _sceneModel;
        private int _enemyCount;
        public BattleScenePresenter(BattleSceneView view)
        {
            _sceneView = view;
            _sceneModel = new BattleSceneModel();
        }

        public void Update()
        {
            _sceneView.SetResult();
        }

        public void SetStageInfo()
        {
            string currStageID = GameManager.currStageID;
            //_sceneModel = model;
            _sceneView.DisplayStageInfo(_sceneModel.GetStageInfo());
            _enemyCount = _sceneModel.GetStageInfo().clearRemoveEnemy;
            _sceneView.OnBattleSceneStart();
        }
    }
}
