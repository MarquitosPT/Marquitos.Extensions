using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Marquitos.Salesforce.Commerce.Helpers
{
    public static class XmlImpex
    {
        public static string ToUtf8Xml<T>(T value)
        {
            var serializer = new XmlSerializer(typeof(T));

            using var stream = new MemoryStream();
            using var writer = new XmlTextWriter(stream, Encoding.UTF8);

            writer.Formatting = Formatting.Indented;

            serializer.Serialize(writer, value);
            return Encoding.UTF8.GetString(stream.ToArray());
        }

        public static string ToXml<T>(T value)
        {
            var serializer = new XmlSerializer(typeof(T));

            using var writer = new StringWriter();

            serializer.Serialize(writer, value);
            return writer.ToString();
        }

        public static T ReadFrom<T>(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(T));

            stream.Position = 0;
            var result = serializer.Deserialize(stream) ?? throw new Exception("Can't deserialize from the provided source.");

            return (T)result;
        }

        public static T ReadFrom<T>(TextReader textReader)
        {
            var serializer = new XmlSerializer(typeof(T));

            var result = serializer.Deserialize(textReader) ?? throw new Exception("Can't deserialize from the provided source.");

            return (T)result;
        }

        public static void WriteTo<T>(T source, Stream destination)
        {
            var serializer = new XmlSerializer(typeof(T));

            serializer.Serialize(destination, source);
        }

        public static void WriteTo<T>(T source, TextWriter destination)
        {
            var serializer = new XmlSerializer(typeof(T));

            serializer.Serialize(destination, source);
        }
    }
}
