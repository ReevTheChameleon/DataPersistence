using UnityEngine;
using UnityEngine.EventSystems;

public class BtnResume : MonoBehaviour,IPointerClickHandler{
	public void OnPointerClick(PointerEventData eventData){
		SceneMainManager.Instance.resume();
	}
}
