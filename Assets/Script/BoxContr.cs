using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxContr : MonoBehaviour
{
	public InputField input1;
	public InputField input2;
	public InputField input3;

	 
	private string correctValue1 = "class"; // значение, которое должно прийти от пользователя 
	private string correctValue2 = "{";
	private string correctValue3 = "}";

	public void CheckInput() // Вызывайте этот метод при нажатии кнопки 
	{




		// Сначала давайте установим весь фон в белый цвет
		input1.GetComponent<Image>().color = Color.white;
		input2.GetComponent<Image>().color = Color.white;
		input3.GetComponent<Image>().color = Color.white;

		bool isCorrect = true;

		// Теперь проверим каждое поле ввода по отдельности
		if (input1.text.Trim() != correctValue1)
		{
			input1.GetComponent<Image>().color = Color.red;
			isCorrect = false;
		}
		if (input2.text.Trim() != correctValue2)
		{
			input2.GetComponent<Image>().color = Color.red;
			isCorrect = false;
		}
		if (input3.text.Trim() != correctValue3)
		{
			input3.GetComponent<Image>().color = Color.red;
			isCorrect = false;
		}

		if (isCorrect)
		{
			SceneManager.LoadScene("Levl5");
		}

		/*if (input1.text.Trim() == correctValue1 && // Если значения всех трех полей соответствуют ожидаемым
			input2.text.Trim() == correctValue2 &&
			input3.text.Trim() == correctValue3)  // Если значение ввода совпадает с ожидаемым значением
		{

			// Загрузите другую сцену
			SceneManager.LoadScene("Menu");
		}
		else
		{
			// меняем цвет фона поля ввода на красный
			input1.GetComponent<Image>().color = Color.red;
			input2.GetComponent<Image>().color = Color.red;
			input3.GetComponent<Image>().color = Color.red;
		}
		*/
	}
}
