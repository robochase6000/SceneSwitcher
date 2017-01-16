using UnityEngine;
using UnityEngine.SceneManagement;

namespace Robochase6000
{
	public class RedDemo : MonoBehaviour
	{
		void Awake()
		{
			MainMenu.Instance.Hide ();
		}

		void OnGUI()
		{
			if (GUILayout.Button ("Exit Red Demo")) {
				SceneList.Instance.Unload (SceneList.EScene.RedDemo);
				MainMenu.Instance.Show ();
			}
		}
	}
}

