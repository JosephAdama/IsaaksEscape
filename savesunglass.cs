using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class savesunglass
{
    public static void SavePlayer(Mainmenu main)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/sunglass.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        sunglassdata data = new sunglassdata(main);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static sunglassdata LoadData()
    {
        string path = Application.persistentDataPath + "/sunglass.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            sunglassdata data = formatter.Deserialize(stream) as sunglassdata;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
   
    
    public static void SavePlayerban(Mainmenu main)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/bananaboat.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        bananaboatbool data = new bananaboatbool(main);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static bananaboatbool LoadDataban()
    {
        string path = Application.persistentDataPath + "/bananaboat.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            bananaboatbool data = formatter.Deserialize(stream) as bananaboatbool;
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


