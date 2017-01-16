using UnityEngine;
using System.Collections;

namespace Robochase6000
{
	public class DontDestroyOnLoad : MonoBehaviour {

		// Use this for initialization
		void Awake()
		{
			DontDestroyOnLoad (gameObject);
		}
	}

}