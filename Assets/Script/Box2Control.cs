using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Box2Control : MonoBehaviour
{
	public InputField input1;
	public InputField input2;
	


	private string correctValue1 = "new"; // ��������, ������� ������ ������ �� ������������ 
	private string correctValue2 = "c.horn";
	

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
			SceneManager.LoadScene("Levl6");
		}
	}

	public void ExitSettings()
	{
		SceneManager.LoadScene("Levels");
	}
}
