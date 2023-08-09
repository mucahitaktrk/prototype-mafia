using System;
using System.IO;
using UnityEngine;

namespace _Game_.Data.Character_Data.Player_Data
{
    [Serializable]
    public class PlayerData 
    {
        public Vector3 playerPosition;
        
        public void Save(PlayerData playerData)
        {
            string jsonData = JsonUtility.ToJson(playerData);
            File.WriteAllText(Application.persistentDataPath + "/oyuncu_data.json", jsonData);
        }

        public PlayerData Load()
        {
            string jsonData = File.ReadAllText(Application.persistentDataPath + "/oyuncu_data.json");
            return JsonUtility.FromJson<PlayerData>(jsonData);
        }
        
        public void DeleteData()
        {
            if (File.Exists(Application.persistentDataPath + "/oyuncu_data.json"))
            {
                File.Delete(Application.persistentDataPath + "/oyuncu_data.json");
                Debug.Log("Veriler başarıyla silindi.");
            }
            else
            {
                Debug.LogWarning("Silinecek veri dosyası bulunamadı.");
            }
        }
    }
}

