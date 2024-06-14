using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SlotDropHandler : MonoBehaviour, IDropHandler
{
	public string acceptedItemTag; // ���, ������� ������ ���� ���������

	public void OnDrop(PointerEventData eventData)
	{
		GameObject droppedItem = eventData.pointerDrag;

		// ��������, ��� droppedItem �� �������� null
		if (droppedItem == null)
		{
			Debug.LogWarning("droppedItem is null");
			return;
		}

		// ��������, ��� � droppedItem ���� ��������� DraggableItem
		DraggableItem draggableItem = droppedItem.GetComponent<DraggableItem>();
		if (draggableItem == null)
		{
			Debug.LogWarning("Dropped item does not have DraggableItem component");
			return;
		}

		if (droppedItem.CompareTag(acceptedItemTag))
		{
			RectTransform droppedRectTransform = droppedItem.GetComponent<RectTransform>();
			droppedRectTransform.SetParent(transform); // ������������� ����� ��������
			droppedRectTransform.anchoredPosition = Vector2.zero; // �������� ������� ������������ ������ ��������
			Debug.Log("Item dropped in the correct slot.");
			draggableItem.isDropped = true;
		}
		else
		{
			Debug.Log("Item dropped in the incorrect slot.");
			droppedItem.GetComponent<RectTransform>().anchoredPosition = draggableItem.originalPosition;
			draggableItem.isDropped = false;
		}
	}
}

