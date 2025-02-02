using UnityEngine;
[RequireComponent(typeof(RectTransform))]
public class safeArea : MonoBehaviour
{
	private void Awake()
	{
		//UpdateSafeArea();
		var safeArea = Screen.safeArea;
		var myRectTransform = GetComponent<RectTransform>();

		var ancherMin = safeArea.position;
		var ancherMax = ancherMin + safeArea.size;

		ancherMin.x /= Screen.width;
		ancherMin.y /= Screen.height;

		ancherMax.x /= Screen.width;
		ancherMax.y /= Screen.height;

		myRectTransform.anchorMin = ancherMin;
		myRectTransform.anchorMax = ancherMax;
	}

	private void UpdateSafeArea()
	{
		

	}
}
