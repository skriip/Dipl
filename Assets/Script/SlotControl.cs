using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SlotControl : MonoBehaviour
{


	// ��������� �������� ��� ��������� ����������, ��� ��� �� ������ ���������� �� � ���������� Unity
	public string input1; // ����� ��� ����� ��� "Item1"
	public string input2; // ����� ��� ����� ��� "Item2"
	public string input3; // ����� ��� ����� ��� "Item3"
	public string input5; // ����� ��� ����� ��� "Item4"
	

	public void CheckSlots() // ��������� ��� ������� ��� ������� �� ������ ��� ��������
	{
		// ������������ ��������� �������� ��� �������� ���������
		string slot1Item = "Item1"; // ���� ��� ������� �������� �� �������� ���������� �������� �� ������ �������� ������������
		string slot2Item = "Item2";
		string slot3Item = "Item3";
		string slot4Item = "Item5";
		

		// ���������� ������ ���� � ��������������� ������
		if (input1 != slot1Item || input2 != slot2Item || input3 != slot3Item || input5 != slot4Item  )
		{
			Debug.Log("�������� � ������ ����������� �������!");
		}
		else
		{
			// ���� ��� �������� ���� � ���������� ������
			SceneManager.LoadScene("NextLevel");
		}
	}
}




