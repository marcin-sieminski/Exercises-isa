using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Ex6
{
    public class FileOperations
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(List<Assignment>));
        private readonly XmlSerializer _deserializer = new XmlSerializer(typeof(List<Assignment>));

        public void CreateFileXml(string path, string fileName, List<Assignment> assignmentsList)
        {
            Directory.CreateDirectory(path);
            using var fileStream = new FileStream(path + fileName, FileMode.Create);
            _serializer.Serialize(fileStream, assignmentsList);
        }

        public Queue<Assignment> LoadFileXmlToQueue(string path, string fileName)
        {
            using StreamReader stream = new StreamReader(path + fileName);
            var xmlDeserialized = (List<Assignment>) _deserializer.Deserialize(stream);
            return new Queue<Assignment>(xmlDeserialized);
        }
    }
}
