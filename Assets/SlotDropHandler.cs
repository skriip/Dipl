using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SlotDropHandler : MonoBehaviour, IDropHandler
{
	public string acceptedItemTag; // Тег, который данный слот принимает

	public void OnDrop(PointerEventData eventData)
	{
		GameObject droppedItem = eventData.pointerDrag;

		// Проверка, что droppedItem не является null
		if (droppedItem == null)
		{
			Debug.LogWarning("droppedItem is null");
			return;
		}

		// Проверка, что у droppedItem есть компонент DraggableItem
		DraggableItem draggableItem = droppedItem.GetComponent<DraggableItem>();
		if (draggableItem == null)
		{
			Debug.LogWarning("Dropped item does not have DraggableItem component");
			return;
		}

		if (droppedItem.CompareTag(acceptedItemTag))
		{
			RectTransform droppedRectTransform = droppedItem.GetComponent<RectTransform>();
			droppedRectTransform.SetParent(transform); // Устанавливаем новый родитель
			droppedRectTransform.anchoredPosition = Vector2.zero; // Обнуляем позицию относительно нового родителя
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

