using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.U2D;
using Game;

namespace GameUI
{
    public class BattleSceneView : SceneView
    {
        private BattleScenePresenter _scenePresenter;
        public Canvas uiCanvas;
        //후에 MainScene 생길시에 없앨 부분 MainScene GameManager 호출해서 사용
        private void Awake()
        {
            CanvasScaler canvasScaler = uiCanvas.GetComponent<CanvasScaler>();
            canvasScaler.referenceResolution = new Vector2(1920, 1080);
            canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            canvasScaler.referencePixelsPerUnit = 108;
        }
        private void Start()
        {
            _scenePresenter = new BattleScenePresenter(this);
            _scenePresenter.SetStageInfo();
        }

        public void DisplayStageInfo(StageInfo stageInfo)
        {
            
            SetBackground(stageInfo.backgroundID);
            //캐릭터 배치 - 플레이어
            //clearCondition 이건 지금 급하니까 하나로 통일
            //캐릭터 배치 - 몬스터
           
            UpdateUIWithStageInfo(stageInfo);
        }


        private void SetBackground(string backgroundID)
        {
            if (uiCanvas == null)
            {
                Debug.LogError("Battle_UI_Canvas not found.");
                return;
            }
            GameObject background = new GameObject("Background");
            background.transform.SetParent(uiCanvas.transform);
            background.AddComponent<Image>().raycastTarget  = false;
            ObjectTransInit(background);
            Sprite bgSprite = Resources.Load<Sprite>(backgroundID);
            background.GetComponent<Image>().sprite = bgSprite;
        }

        public void SetResult()
        {

        }

        public void OnBattleSceneStart()
        {
            Debug.Log("BattleScene이 시작되었습니다!");
        }

        private void UpdateUIWithStageInfo(StageInfo stageInfo)
        {
            Debug.Log("현재 스테이지 정보:"+stageInfo.backgroundID);
        }
        public void Dispose()
        {

        }
    }
}
