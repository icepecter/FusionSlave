using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.Networking;

public class WebAPI : MonoBehaviour
{
    // API_URL�� �Լ� ������Ʈ�ÿ� ������ �ǹǷ� ������Ʈ �ʿ�
    [SerializeField] private string API_URL = "https://script.google.com/macros/s/AKfycbxxsZGNJpxuLD0MxPche9SCQDQU1mXU-OOFxHh2USdj7N_HeZ8JDKA-eMZLXg2jVOTd/exec";

    #region API �� Data�� ������ ��� ( Sample Code )
    //IEnumerator Start()
    //{ 
    //    // GET : �ܼ��� �����͸� �����´� ũ�� ��� �� ���� ����.
    //    UnityWebRequest getHandle = UnityWebRequest.Get(API_URL);   
    //    yield return getHandle.SendWebRequest();

    //    // POST : order�� �����Ͽ� ������.
    //    WWWForm postForm = new WWWForm();       // Form �����͸� ������.
    //    postForm.AddField("oreder","login");    // ������ �Լ� �̸��� ����.
    //    postForm.AddField("data","player");     // �߰��� �Ű������� �ְ� ������ �߰��Ѵ�.

    //    UnityWebRequest postHandle = UnityWebRequest.Post(API_URL, postForm);
    //    yield return postHandle.SendWebRequest();
    //}
    #endregion
}
