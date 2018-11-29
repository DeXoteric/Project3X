using UnityEngine;

namespace Project3X
{
    public class LoadGame : MonoBehaviour
    {

        
        public void OnClickLoadGame()
        {
            DataManager.LoadGame("data");

            Galaxy galaxy = new Galaxy(DataManager.saveData.seedNumber,
                                        DataManager.saveData.numberOfStars,
                                        DataManager.saveData.minimumRadius,
                                        DataManager.saveData.maximumRadius,
                                        DataManager.saveData.minDistBetweenStars);
        }

        
    }
}