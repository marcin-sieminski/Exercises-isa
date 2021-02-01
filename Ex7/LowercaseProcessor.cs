namespace Ex7
{
    public class LowercaseProcessor : IProcessor
    {
        public string ProcessText(string textToProcess)
        {
            return textToProcess.ToLower();
        }
    }
}
