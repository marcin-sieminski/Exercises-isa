namespace Ex7
{
    public class UppercaseProcessor : IProcessor
    {
        public string ProcessText(string textToProcess)
        {
            return textToProcess.ToUpper();
        }
    }
}
