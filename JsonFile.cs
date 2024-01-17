using Uaine.IO;

namespace Uaine.Archive
{
    public static class JsonFileType
    {
        public const int Object = 0;
        public const int Array = 1;
    }
    public class JsonFile : FileData
    {
        public int Type { get; private set; }
        public JsonFile(string filename, int type) : base(filename)
        {
            Type = type;
        }
    }
}
