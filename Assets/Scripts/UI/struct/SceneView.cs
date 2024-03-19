using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUI
{
    public class SceneView : MonoBehaviour, ISceneView
    {
        protected void ObjectTransInit(GameObject obj)
        {
            RectTransform rectTransform = obj.GetComponent<RectTransform>();
            if (rectTransform == null)
            {
                rectTransform = obj.AddComponent<RectTransform>();
            }
            rectTransform.anchorMin = new Vector2(0, 0);
            rectTransform.anchorMax = new Vector2(1, 1);
            rectTransform.pivot = new Vector2(0.5f, 0.5f);
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localScale = Vector3.one;
        }

        public void Dispose()
        {

        }
    }
}