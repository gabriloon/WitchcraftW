using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

namespace Game
{
    public class GameManager 
    {
        public static string currStageID = Stage.STAGE_1_1;
        private void Awake()
        {
            // Screen.SetResolution(1920, 1080, true);
            // PixelPerfectCamera camera = Camera.main.GetComponent<PixelPerfectCamera>();
            // camera.refResolutionX = 1920;
            // camera.refResolutionY = 1080;
            // camera.assetsPPU = 83; 
        }
    }
}
