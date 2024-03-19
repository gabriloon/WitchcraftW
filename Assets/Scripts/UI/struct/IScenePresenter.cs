namespace GameUI
{
    public interface IScenePresenter
    {
        void Create(ISceneView sceneView, ISceneModel sceneModel, ISceneInfo sceneInfo);
        ISceneView GetSceneView();
        ISceneModel GetSceneModel();
        ISceneInfo GetSceneInfo();
    }
}