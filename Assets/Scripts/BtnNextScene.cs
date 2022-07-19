using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Chameleon;

public class BtnNextScene : MonoBehaviour,IPointerClickHandler{
	[SerializeField] SceneIndex sceneIndex;
	public void OnPointerClick(PointerEventData eventData){
		SceneManager.LoadSceneAsync(sceneIndex.Index);
	}
}
