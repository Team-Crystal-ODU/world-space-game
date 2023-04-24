using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public static class APIHelper 
{
    public static IEnumerator ExecuteRequest(UnityWebRequest request, Action<UnityWebRequest> onSuccessCallBack)
    {
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            request.Dispose();
            Debug.Log(request.result);
            yield break;
        }
        

        onSuccessCallBack.Invoke(request);
        request.Dispose();
    }

}
