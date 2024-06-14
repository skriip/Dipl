using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private RectTransform rectTransform;
	private CanvasGroup canvasGroup;
	public Vector2 originalPosition;
	public bool isDropped = false;

	private void Awake()
	{
		rectTransform = GetComponent<RectTransform>();
		canvasGroup = GetComponent<CanvasGroup>();
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		originalPosition = rectTransform.anchoredPosition;
		canvasGroup.blocksRaycasts = false;
		isDropped = false; // �������� ���� ��� ������ ��������������
		transform.SetAsLastSibling(); // ���������� ������� ������ �� ��������
	}

	public void OnDrag(PointerEventData eventData)
	{
		rectTransform.anchoredPosition += eventData.delta;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		canvasGroup.blocksRaycasts = true;
		// ������������ �������, ���� ������� �� ��� ��������� � ����
		if (!isDropped)
		{
			rectTransform.anchoredPosition = originalPosition;
		}
	}
}
