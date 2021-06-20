using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class Saveforest
{
    public static void SavePlayer(winlvl2 win)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.Playscore2";
        FileStream stream = new FileStream(path, FileMode.Create);

        Forestdata data = new Forestdata(win);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Forestdata LoadData()
    {
        string path = Application.persistentDataPath + "/player.Playscore2";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            
            Forestdata data = formatter.Deserialize(stream) as Forestdata;
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