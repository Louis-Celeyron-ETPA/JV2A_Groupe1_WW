using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bouton : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	public void TaskOnClick()
	{
		Debug.Log("Perdu !");
	}
}