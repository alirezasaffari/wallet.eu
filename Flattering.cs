namespace Flattering;

public static class Flatter
{
    public static List<object> results = new();
    public static List<object> MakeFlat(List<object> input)
    {
        for (int i = 0; i < input.Count; i++)
			{
            if(input[i] is int)
                results.Add(input[i]);
                    else
                MakeFlat((List<object>)input[i]);
			}
        return results;
    }
}
