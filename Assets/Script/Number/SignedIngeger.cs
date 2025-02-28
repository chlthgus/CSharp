using UnityEngine;

public class SignedIngeger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //SignedIngeger
        sbyte iSbyte = 127; //ũ�� = 8��Ʈ (1����Ʈ) ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        short iInt16 = 32767; //ũ�� = 16��Ʈ (1����Ʈ) ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        int iInt32 = 2147483647; //ũ�� = 32��Ʈ (1����Ʈ) ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        long Iint64 = 9223372036845775807; //ũ�� = 64��Ʈ (1����Ʈ) ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("sbyte: " + iSbyte);
        Debug.Log("short: " + iInt16);
        Debug.Log("int: " + iInt32);
        Debug.Log("long: " + Iint64);

        //UnSignedIngeger
        byte ibyte = 255; //ũ�� = 8��Ʈ (1����Ʈ) ��ȣ�� ��?�� ������ ���� ���� �� �ʱ�ȭ
        ushort iUInt16 = 65535; //ũ�� = 16��Ʈ (1����Ʈ) ��ȣ�� ��?�� ������ ���� ���� �� �ʱ�ȭ
        //uint iUInt32 = 4294967295; //ũ�� = 32��Ʈ (1����Ʈ) ��ȣ�� ��?�� ������ ���� ���� �� �ʱ�ȭ
        ulong iUint64 = 18446744073709551615 ; //ũ�� = 64��Ʈ (1����Ʈ) ��ȣ�� ��?�� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("byte: " + ibyte);
        Debug.Log("ushort: " + iUInt16);
        Debug.Log("ulong: " + iUint64);


    }

}


/*
 1 Bit 0,1
 1 Byte  : 8 Bit
     ��0000 0000     -> 0
        ��0000 0001      -> 1  
            ��0000 0010      -> 2
                ��0000 0011      -> 3
                    ��0000 0100      -> 4

8Bit 

(+, -, 0)
sbyte : -128 ~ 127

(+, 0)
byte : 0 ~ 255

 */

/*

SignedIngeger (+, -) ��ȣ�� �ִ� ������ ������ ����(Ÿ��)




UnSignedIngeger (+, -) ��ȣ�� ���� ������ ������ ����(Ÿ��)

 */
