using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
public class DataFetcher : MonoBehaviour{

    private const string url = "http://127.0.0.1:8080/test"; ///
    private WaitForSeconds fetchInterval = new WaitForSeconds(1f);

    private IEnumerator Start(){
        while (true){
            yield return StartCoroutine(FetchData());
            yield return fetchInterval;
        }
    }

    private IEnumerator FetchData(){
        using (UnityWebRequest w = UnityWebRequest.Get(url)){
            yield return w.SendWebRequest();
            if (w.result == UnityWebRequest.Result.Success){
                string data = www.downloadHandler.text;
                Debug.Log(data);
            } else{
                Debug.LogError(w.error);
            }
        }
    }
}

