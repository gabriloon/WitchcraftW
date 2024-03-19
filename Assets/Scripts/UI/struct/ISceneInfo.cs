using System;
namespace GameUI
{
    public interface ISceneInfo {
        string prevSceneName { get; set; }
        string sceneName { get; set; }
    }
}