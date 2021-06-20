using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Savegeodata
{
    public static void SavePlayer(Dieinspace die)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.Playscore4";
        FileStream stream = new FileStream(path, FileMode.Create);

        geodata data = new geodata(die);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static geodata LoadData()
    {
        string path = Application.persistentDataPath + "/player.Playscore4";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            geodata data = formatter.Deserialize(stream) as geodata;
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
