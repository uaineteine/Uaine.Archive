using Uaine.IO;

namespace Uaine.Archive
{
    public class JsonArrary<T>
    {
        public T[] Items { get; private set; }
        public int Size { get => Items.Length; }

        public JsonArrary(string[] json)
        {
            Items = ArraySerialiser.DeserializeFromJson<T>(json);
        }
    }
}
