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
    public static bool register = false;


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

    public static void addStats()
    {
        if (!instance)
        {
            instance = FindObjectOfType<DBManager>();

            if (!instance)
            {
                instance = new GameObject("CoroutineExecuter").AddComponent<DBManager>();
            }
        }

        instance.StartCoroutine(CreatePlayer(NewPlayer.getAnun()));
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

            var dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(www.downloadHandler.text);
            Debug.Log(dic.Count);
            if (dic.Count > 1)
            {
                Debug.Log(dic["nickname"]);
                Debug.Log(dic["tocken"]);
                Debug.Log(dic["hash"]);
                nickname = dic["nickname"];
                tocken = dic["tocken"];
                hash = dic["hash"];
                register = true;
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
            nickname = name;
        }
    }

    private static IEnumerator CreatePlayer(string nickname)
    {
        WWWForm form = new WWWForm();
        form.AddField("nickname", nickname);
        

        UnityWebRequest www = UnityWebRequest.Post("http://amo777ak.bget.ru/newPlayer/", form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
            //string name = www.downloadHandler.text;
            
        }
    }


}
