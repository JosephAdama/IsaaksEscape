using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class savebool
{
    public static void SavePlayer(Mainmenu main)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/coin.unlocked";
        FileStream stream = new FileStream(path, FileMode.Create);

        booldata data = new booldata(main);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static booldata LoadData()
    {
        string path = Application.persistentDataPath + "/coin.unlocked";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            booldata data = formatter.Deserialize(stream) as booldata;
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
