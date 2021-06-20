using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class Savelvl1 
{
    public static void SavePlayer(winlvl1 win)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.Playscore1";
        FileStream stream = new FileStream(path, FileMode.Create);

        lvl1hillData data = new lvl1hillData(win);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static lvl1hillData LoadData()
    {
        string path = Application.persistentDataPath + "/player.Playscore1";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            lvl1hillData data = formatter.Deserialize(stream) as lvl1hillData;
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
