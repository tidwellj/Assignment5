using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]
public class SaveJson : MonoBehaviour
{

    static public int expo2 = 0;
    static public int altScore = 0;
    static public string difficulty2;


    [System.Serializable]
    public class MyClass
    {
       
        
        public string playerName;
        public string difficulty;
        public float rotatorSpeed;
        public int lives;
        public int score;
        public float time;
       // public int music;
        

    }
    public   SaveJson.MyClass myObject = new SaveJson.MyClass();
    public void Start()
    {



    }

    public void SavvIt()
    {
        myObject.playerName = NameText.userIDs;
        myObject.score = WordDisplay.score;
        myObject.difficulty = DropD1.lives;
        //myObject.rotatorSpeed = RotatorSpeed.rotatorSpeed;
        //myObject.lives = GameManager.lives;
        //myObject.time = TimeSlider.timeSlider;
       // myObject.music = Toggles.tog;
        Debug.Log(myObject.playerName);
       
        var json = JsonUtility.ToJson(myObject);
        
        Debug.Log(myObject.score);
        PlayerPrefs.SetString("Save", json);
       
        PlayerPrefs.Save();
        expo2 = 0;
    }

    public void LoadIt()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        string json = PlayerPrefs.GetString("Save");
       
        myObject = JsonUtility.FromJson<SaveJson.MyClass>(json);
      

      

       NameText.userIDs = myObject.playerName;
        WordDisplay.score = myObject.score;
        DropD1.lives = myObject.difficulty;
        difficulty2 = myObject.difficulty;

        //altScore = myObject.score;
        //RotatorSpeed.rotatorSpeed = myObject.rotatorSpeed;
        // GameManager.lives = myObject.lives;
        // altLives = myObject.lives;

        //PinSpeed.pinSpeed = myObject.pinSpeed;
        //expo6 = myObject.music;
        PlayerPrefs.Save();
        
        expo2 = 1;
    }
   
    
}
