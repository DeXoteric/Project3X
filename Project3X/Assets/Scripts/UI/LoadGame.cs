using UnityEngine;

namespace Project3X
{
    public class LoadGame : MonoBehaviour
    {
        //public static SaveData saveData;

        public void OnClickLoadGame()
        {

            SaveData.saveData = DataManager.Load<SaveData>("save");

            Galaxy galaxy = new Galaxy(SaveData.saveData.seedNumber,
                SaveData.saveData.numberOfStars,
                SaveData.saveData.minimumRadius,
                SaveData.saveData.maximumRadius,
                SaveData.saveData.minDistBetweenStars);

        }
    }
}