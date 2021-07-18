using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    

    public void startGame()
    {
        NewPlayer.createNewPlayer();
        SceneManager.LoadScene("UserScene");
    }

    public void GnalXanut()
    {
        SceneManager.LoadScene("Xanut");
        NewPlayer.setPagerText("Bari galust Xanut. inch kcankanaq gnel?");
    }

    public void GtnelAshxatanq()
    {
        SceneManager.LoadScene("Ashxatanq");
        NewPlayer.setPagerText("Bari galust Ashxatashuka.");
    }

    public void OpenInventar()
    {
        SceneManager.LoadScene("Inventar");
        NewPlayer.setPagerText("exac-chexact esa axper...");
    }

    public void backToUserScene()
    {
        SceneManager.LoadScene("UserScene");
        NewPlayer.setPagerText("");
    }

}