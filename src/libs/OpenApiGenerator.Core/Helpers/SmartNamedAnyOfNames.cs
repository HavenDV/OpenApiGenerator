namespace OpenApiGenerator.Core.Helpers;

public static class SmartNamedAnyOfNames
{
    public static string ComputeSmartName(string typeName, string className)
    {
        var nameWords = SplitToWordsByUpperCharacters(typeName);
        var classNameWords = SplitToWordsByUpperCharacters(className);

        // Combine the unique strings from both collections
        return string.Concat(
            nameWords.Except(classNameWords));
    }
    
    public static IReadOnlyList<string> SplitToWordsByUpperCharacters(string text)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        
        var words = new List<string>();
        var startIndex = 0;
        for (var i = 1; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                words.Add(text.Substring(startIndex, i - startIndex));
                startIndex = i;
            }
        }
        words.Add(text.Substring(startIndex));

        return words;
    }
}