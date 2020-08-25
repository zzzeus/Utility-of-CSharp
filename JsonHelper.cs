using System.Text.Json;

class JsonHelper{
    public static string Serialize(object obj){
        var jsonString = JsonSerializer.Serialize(obj);
        return jsonString;
    }
    public static T Deserialize<T>(string jsonString){
        var obj = JsonSerializer.Deserialize<T>(jsonString);
        return obj;
    }
}