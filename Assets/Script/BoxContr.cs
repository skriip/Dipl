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

	 
	private string correctValue1 = "class"; // ��������, ������� ������ ������ �� ������������ 
	private string correctValue2 = "{";
	private string correctValue3 = "}";

	public void CheckInput() // ��������� ���� ����� ��� ������� ������ 
	{




		// ������� ������� ��������� ���� ��� � ����� ����
		input1.GetComponent<Image>().color = Color.white;
		input2.GetComponent<Image>().color = Color.white;
		input3.GetComponent<Image>().color = Color.white;

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
		if (input3.text.Trim() != correctValue3)
		{
			input3.GetComponent<Image>().color = Color.red;
			isCorrect = false;
		}

		if (isCorrect)
		{
			SceneManager.LoadScene("Levl5");
		}

		/*if (input1.text.Trim() == correctValue1 && // ���� �������� ���� ���� ����� ������������� ���������
			input2.text.Trim() == correctValue2 &&
			input3.text.Trim() == correctValue3)  // ���� �������� ����� ��������� � ��������� ���������
		{

			// ��������� ������ �����
			SceneManager.LoadScene("Menu");
		}
		else
		{
			// ������ ���� ���� ���� ����� �� �������
			input1.GetComponent<Image>().color = Color.red;
			input2.GetComponent<Image>().color = Color.red;
			input3.GetComponent<Image>().color = Color.red;
		}
		*/
	}
}
