using UnityEngine;

namespace GameUI
{
    public class ScenePresenter : MonoBehaviour, IScenePresenter
    {
        private ISceneView _sceneView;
        private ISceneModel _sceneModel;
        private ISceneInfo _sceneInfo;
        public ISceneInfo GetSceneInfo()
        {
            return _sceneInfo;
        }

        public ISceneModel GetSceneModel()
        {
            return _sceneModel;
        }

        public ISceneView GetSceneView()
        {
            return _sceneView;
        }
        virtual public void Create(ISceneView sceneView, ISceneModel sceneModel, ISceneInfo sceneInfo)
        {
            _sceneView = sceneView;
            _sceneModel = sceneModel;
            _sceneInfo = sceneInfo;
        }

    }
}