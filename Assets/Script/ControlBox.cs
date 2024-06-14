using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlBox : MonoBehaviour
{
	public InputField input1;
	public InputField input2;



	private string correctValue1 = "d."; // значение, которое должно прийти от пользователя 
	private string correctValue2 = "7";


	public void CheckInput() // Вызывайте этот метод при нажатии кнопки 
	{




		// Сначала давайте установим весь фон в белый цвет
		input1.GetComponent<Image>().color = Color.white;
		input2.GetComponent<Image>().color = Color.white;


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


		if (isCorrect)
		{
			SceneManager.LoadScene("Levl7");
		}
	}
}
