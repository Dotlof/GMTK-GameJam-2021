using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SaveVolume (scr_Volume_slider volume)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/volume.bin";
        FileStream stream = new FileStream(path, FileMode.Create);

        VolumeData data = new VolumeData(volume);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static VolumeData LoadVolume()
    {
        string path = Application.persistentDataPath + "/volume.bin";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            VolumeData data = formatter.Deserialize(stream) as VolumeData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
