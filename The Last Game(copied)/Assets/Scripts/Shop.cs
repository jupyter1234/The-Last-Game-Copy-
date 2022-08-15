using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shop : MonoBehaviour
{
    //������ [����,����,�Ŀ� ��,Ʈ����]
    public GameManager gameManager;
    public GameObject[] Pages;
    public int pageIndex;
    public int[] ItemPrice;

    //���� ������ ������ �ѱ��
    public void NextPage()
    {
        if (pageIndex == 0)
        {
            Pages[pageIndex].SetActive(false);
            pageIndex++;
            Pages[pageIndex].SetActive(true);
        }

    }
    //���� ������ �ڷ� �ѱ��
    public void PrePage()
    {
        if (pageIndex == 1)
        {
            Pages[pageIndex].SetActive(false);
            pageIndex--;
            Pages[pageIndex].SetActive(true);
        }
    }
    //Buy Item
    public void Buy(int index)
    {
        int price = ItemPrice[index];
        if (gameManager.Coin >= price)  //���� ���� ����� ���
        {
            gameManager.Coin -= price;
            gameManager.itemsCount[index]++;
        }
        //Debug.Log(price);
    }
}
