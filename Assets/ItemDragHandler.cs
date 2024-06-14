using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private RectTransform rectTransform;
	private CanvasGroup canvasGroup;
	private Vector2 originalPosition;

	private void Awake()
	{
		rectTransform = GetComponent<RectTransform>();
		canvasGroup = GetComponent<CanvasGroup>();
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		originalPosition = rectTransform.anchoredPosition;
		canvasGroup.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData eventData)
	{
		rectTransform.anchoredPosition += eventData.delta;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		canvasGroup.blocksRaycasts = true;
		// Восстановить позицию, если предмет не был перетащен в слот
		if (!eventData.pointerDrag.GetComponent<DraggableItem>().isDropped)
		{
			rectTransform.anchoredPosition = originalPosition;
		}
	}
}