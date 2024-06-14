using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SlotControl : MonoBehaviour
{


	// Объявляем элементы как публичные переменные, так что вы можете установить их в инспекторе Unity
	public string input1; // здесь все равно что "Item1"
	public string input2; // здесь все равно что "Item2"
	public string input3; // здесь все равно что "Item3"
	public string input5; // здесь все равно что "Item4"
	

	public void CheckSlots() // вызываете эту функцию при нажатии на кнопку для проверки
	{
		// предоставьте фиктивные значения для проверки концепции
		string slot1Item = "Item1"; // этот код следует изменить на реальное извлечение значений из вашего игрового пространства
		string slot2Item = "Item2";
		string slot3Item = "Item3";
		string slot4Item = "Item5";
		

		// сравнивает каждый слот с соответствующим вводом
		if (input1 != slot1Item || input2 != slot2Item || input3 != slot3Item || input5 != slot4Item  )
		{
			Debug.Log("Предметы в слотах расставлены неверно!");
		}
		else
		{
			// если все предметы были в правильных слотах
			SceneManager.LoadScene("NextLevel");
		}
	}
}




