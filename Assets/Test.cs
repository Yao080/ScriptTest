using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // �z�������������
        int[] array = { 10, 20, 30, 40, 50 };

        
        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        // �z��̗v�f�����ׂċt�ɕ\��������
        for (int i = array.Length -1; i >= 0 ; i--)
        {
            Debug.Log(array[i]);
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
