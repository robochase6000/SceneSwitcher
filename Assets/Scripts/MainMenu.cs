using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;

namespace Robochase6000
{
	public class MainMenu : MonoBehaviour 
	{
		static public MainMenu Instance { get; private set; }

		void Awake()
		{
			if (Instance != null) {
				Destroy (gameObject);
				return;
			}

			Instance = this;

			DontDestroyOnLoad (gameObject);
		}

		void OnDestroy()
		{
			if (Instance == this) {
				Instance = null;
			}
		}

		void OnGUI()
		{
			if (GUILayout.Button ("Red Demo")) {
				SceneList.Instance.Load (SceneList.EScene.RedDemo, LoadSceneMode.Additive);
			}

			if (GUILayout.Button ("Blue Demo")) {
				SceneList.Instance.Load (SceneList.EScene.BlueDemo, LoadSceneMode.Additive);
			}
		}

		public void Show()
		{
			gameObject.SetActive (true);
		}

		public void Hide()
		{
			gameObject.SetActive (false);
		}
	}
}
