using UnityEngine;

namespace Robochase6000
{
	public class SceneList : MonoBehaviour {
		static public SceneList Instance { get; private set; }

		public enum EScene
		{
			MainMenu,
			RedDemo,
			BlueDemo,
		}

		[System.Serializable]
		public class SceneListing
		{
			public EScene SceneType;
			public string SceneToLoad;
		}
		public SceneListing[] Scenes;

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

		public void Load(EScene sceneType, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode = UnityEngine.SceneManagement.LoadSceneMode.Single)
		{
			string sceneName = SceneName (sceneType);
			if (!string.IsNullOrEmpty (sceneName)) {
				UnityEngine.SceneManagement.SceneManager.LoadScene (sceneName, loadSceneMode);
			}
		}

		public void Unload(EScene sceneType)
		{
			string sceneName = SceneName (sceneType);
			if (!string.IsNullOrEmpty (sceneName)) {
				UnityEngine.SceneManagement.SceneManager.UnloadScene (sceneName);
			}
		}

		public string SceneName(EScene sceneType)
		{
			for (int i = 0; i < Scenes.Length; i++) {
				if (Scenes [i].SceneType == sceneType) {
					return Scenes [i].SceneToLoad;
				}
			}
			return null;
		}
	}
}