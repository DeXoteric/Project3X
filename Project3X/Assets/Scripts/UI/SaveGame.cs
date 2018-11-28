using UnityEngine;

namespace Project3X
{
    public class SaveGame : MonoBehaviour
    {
        
        public void OnClickSaveGame()
        {
            DataManager.Save<SaveData>(SaveData.saveData, "save");
            
        }
    }
}