using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.Networking;

public class WebAPI : MonoBehaviour
{
    // API_URL은 함수 업데이트시에 변동이 되므로 업데이트 필요
    [SerializeField] private string API_URL = "https://script.google.com/macros/s/AKfycbxxsZGNJpxuLD0MxPche9SCQDQU1mXU-OOFxHh2USdj7N_HeZ8JDKA-eMZLXg2jVOTd/exec";

    #region API 에 Data를 보내는 방법 ( Sample Code )
    //IEnumerator Start()
    //{ 
    //    // GET : 단순히 데이터만 가져온다 크게 사용 할 일은 없다.
    //    UnityWebRequest getHandle = UnityWebRequest.Get(API_URL);   
    //    yield return getHandle.SendWebRequest();

    //    // POST : order를 지정하여 보낸다.
    //    WWWForm postForm = new WWWForm();       // Form 데이터를 보낸다.
    //    postForm.AddField("oreder","login");    // 실행할 함수 이름을 고른다.
    //    postForm.AddField("data","player");     // 추가로 매개변수를 넣고 싶을시 추가한다.

    //    UnityWebRequest postHandle = UnityWebRequest.Post(API_URL, postForm);
    //    yield return postHandle.SendWebRequest();
    //}
    #endregion
}
