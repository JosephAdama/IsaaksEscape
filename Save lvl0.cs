using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Savelvl0 
{

    public static void SavePlayer (winlvl0 win)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.Playscore0";
        FileStream stream = new FileStream(path, FileMode.Create);

        lvl1Data data = new lvl1Data(win);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static lvl1Data LoadData()
    {
        string path = Application.persistentDataPath + "/player.Playscore0";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            lvl1Data data = formatter.Deserialize(stream) as lvl1Data;
            stream.Close();
            return data;  
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }



    }


}
