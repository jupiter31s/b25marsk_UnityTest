using UnityEngine;
using UnityEngine.SceneManagement;




public class MoveToNextLevel : MonoBehaviour
{
    private string Level2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  
  


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Square") // Object name
        {
            SceneManager.LoadScene(1);
        }
    }
    // Update is called once per frame
  
}