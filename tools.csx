using System.Text.Json;

void Assert<T>(T except, T value)
{
    var v1 = JsonSerializer.Serialize(except);
    var v2 = JsonSerializer.Serialize(value);
    if (v1 != v2) {
        throw new Exception($"Except {v1} but take {v2}!");
    }
}