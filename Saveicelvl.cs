using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Saveicelvl 
{
    public static void SavePlayer(winice win)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.Playscore3";
        FileStream stream = new FileStream(path, FileMode.Create);

        Icelvldata data = new Icelvldata(win);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Icelvldata LoadData()
    {
        string path = Application.persistentDataPath + "/player.Playscore3";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            Icelvldata data = formatter.Deserialize(stream) as Icelvldata;
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
