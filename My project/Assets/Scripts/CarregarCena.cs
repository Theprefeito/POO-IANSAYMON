using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{
   public string sceneName;
   
   public void Load()
   {
      SceneManager.LoadScene("Jogo");
   }

}