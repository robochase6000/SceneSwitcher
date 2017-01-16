using UnityEngine;

namespace Robochase6000
{
	public class Mover : MonoBehaviour
	{
		public float MoveSpeed = 10f;

		void Update()
		{
			if (Input.GetKey (KeyCode.LeftArrow)) {
				transform.Translate (Vector3.right * -MoveSpeed * Time.deltaTime);
			} else if (Input.GetKey (KeyCode.RightArrow)) {
				transform.Translate (Vector3.right * MoveSpeed * Time.deltaTime);
			}
		}
	}
}

