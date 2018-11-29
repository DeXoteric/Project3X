using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Project3X
{
    public static class DataManager
    {
        public static SaveData saveData;

       

        public static void SaveGame(string fileName)
        {
            

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(
                string.Format("{0}/{1}.dat", Application.dataPath, fileName),
                FileMode.OpenOrCreate);
            bf.Serialize(file, saveData);
            file.Close();
        }

        public static void LoadGame(string fileName)
        {
            string path = string.Format("{0}/{1}.dat", Application.dataPath, fileName);
            if (File.Exists(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(path, FileMode.Open);
                saveData = (SaveData)bf.Deserialize(file);
                file.Close();

               
            }
        }

        //public static void Save<T>(T data, string fileName)
        //where T : struct
        //{
        //    BinaryFormatter bf = new BinaryFormatter();
        //    FileStream file = File.Open(
        //        string.Format("{0}/{1}.dat", Application.dataPath, fileName),
        //        FileMode.OpenOrCreate);
        //    bf.Serialize(file, data);
        //    file.Close();
        //}

        //public static T Load<T>(string fileName)
        //    where T : struct
        //{
        //    string path = string.Format("{0}/{1}.dat", Application.dataPath, fileName);
        //    if (File.Exists(path))
        //    {
        //        var bf = new BinaryFormatter();
        //        var file = File.Open(path, FileMode.Open);
        //        var data = (T)bf.Deserialize(file);
        //        file.Close();

        //        return data;
        //    }

        //    return default(T);
        //}
    }
}