using Uaine.IO;
using Newtonsoft.Json;

namespace Uaine.Archive
{
    public static class JsonFileType
    {
        public const int Object = 0;
        public const int Array = 1;
    }

    public class JsonFile<T> : FileData
    {
        public int Type { get; private set; }
        public DataArray<T> Dataarray { get; private set; }
        public T DataObject { get; private set; }

        public DataArray(string filename, int type, string[] json) : base(filename)
        {
            Type = type;
            if (type == JsonFileType.Array)
            {
                Dataarray = new DataArray<T>(json);
            }
            else if (type == JsonFileType.Object)
            {
                DataObject = JsonConvert.DeserializeObject<T>(string.Join("", json));
            }
        }


    }
}
