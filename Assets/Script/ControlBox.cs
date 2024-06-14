using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlBox : MonoBehaviour
{
	public InputField input1;
	public InputField input2;



	private string correctValue1 = "d."; // ��������, ������� ������ ������ �� ������������ 
	private string correctValue2 = "7";


	public void CheckInput() // ��������� ���� ����� ��� ������� ������ 
	{




		// ������� ������� ��������� ���� ��� � ����� ����
		input1.GetComponent<Image>().color = Color.white;
		input2.GetComponent<Image>().color = Color.white;


		bool isCorrect = true;

		// ������ �������� ������ ���� ����� �� �����������
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
