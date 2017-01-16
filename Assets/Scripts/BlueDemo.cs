using UnityEngine;
using UnityEngine.SceneManagement;

namespace Robochase6000
{
	public class BlueDemo : MonoBehaviour
	{
		void Awake()
		{
			MainMenu.Instance.Hide ();
		}

		void OnGUI()
		{
			if (GUILayout.Button ("Exit Blue Demo")) {
				SceneList.Instance.Unload (SceneList.EScene.BlueDemo);
				MainMenu.Instance.Show ();
			}
		}
	}
}

