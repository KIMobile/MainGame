using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;

public class DBManager : MonoBehaviour
{
    private static DBManager instance;

    public static string nickname = "";
    public static string tocken = "";
    public static string hash = "";


    public static void checkUsername()
    {
        if (!instance)
        {
            instance = FindObjectOfType<DBManager>();

            if (!instance)
            {
                instance = new GameObject("CoroutineExecuter").AddComponent<DBManager>();
            }
        }

        instance.StartCoroutine(Register(NewPlayer.getAnun()));
    }

    public static void checkAuthorization(string token, string hash)
    {
        if (!instance)
        {
            instance = FindObjectOfType<DBManager>();

            if (!instance)
            {
                instance = new GameObject("CoroutineExecuter").AddComponent<DBManager>();
            }
        }

        instance.StartCoroutine(Authorize(token, hash));
    }

    static IEnumerator Register(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("email", "barev@hajox.am");
        form.AddField("nickname", username);

        UnityWebRequest www = UnityWebRequest.Post("http://amo777ak.bget.ru/register/", form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            
            //ShowPagerFromDB.setPagerText(www.downloadHandler.text);

            var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(www.downloadHandler.text);
            Debug.Log(dic.Count);
            if (dic.Count > 1)
            {
                Debug.Log(dic["id"]);
                Debug.Log(dic["nickname"]);
                Debug.Log(dic["tocken"]);
                Debug.Log(dic["hash1"]);
                nickname = dic["nickname"];
                tocken = dic["tocken"];
                hash = dic["hash1"];
            } else
            {
                Debug.Log(dic["error"]);
            }

        }
    }

    private static IEnumerator Authorize(string token, string hash)
    {
        WWWForm form = new WWWForm();
        form.AddField("tocken", token);
        form.AddField("hash", hash);

        UnityWebRequest www = UnityWebRequest.Post("http://amo777ak.bget.ru/login/", form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            string name = www.downloadHandler.text;
            Authorisation.setNickname(name);
            //ShowPagerFromDB.setPagerText(www.downloadHandler.text);

            //var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(www.downloadHandler.text);
            //string token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            //Debug.Log(token);
            //Debug.Log(dic["id"]);
            //Debug.Log(dic["name"]);
            //Debug.Log(dic["password"]);
        }
    }


}
