namespace Ex7
{
    class LowercaseProcessor : IProcessor
    {
        public string ProcessText(string textToProcess)
        {
            return textToProcess.ToLower();
        }
    }
}
