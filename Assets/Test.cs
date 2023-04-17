using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 配列を初期化する
        int[] array = { 10, 20, 30, 40, 50 };

        
        // 配列の要素をすべて表示する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        // 配列の要素をすべて逆に表示させる
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
