void Assert<T>(T except, T value)
{
    if (!except.Equals(value)) {
        throw new Exception($"Except {except} but take {value}!");
    }
}