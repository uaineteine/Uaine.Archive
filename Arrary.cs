using Uaine.IO;

namespace Uaine.Archive
{
    public class Arrary<T>
    {
        public T[] Items { get; private set; }
        public int Size { get => Items.Length; }

        public Arrary(string[] json)
        {
            Items = ArraySerialiser.DeserializeFromJson<T>(json);
        }
        public Arrary(T[] items)
        {
            Items = items;
        }
        public string[] SerialiseToJSON()
        {
            return ArraySerialiser.SerializeToJson<T>(Items);
        }
    }
}
