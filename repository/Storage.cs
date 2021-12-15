using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Boom21.repository
{
    public class Storage<TIdentifier> where TIdentifier : IIdentifier
    {
        private static readonly string Path = "Storages/" + typeof(TIdentifier).Name + "s.xml";
        private List<TIdentifier> _storage = new();

        public Storage() { }

        public void ReadFromXmlFile()
        {
            if (!File.Exists(Path)) return;
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(Path, FileMode.Open);
            _storage = (List<TIdentifier>)xs.Deserialize(fs);
        }

        public void SaveToXmlFile()
        {
            var xs = new XmlSerializer(typeof(List<TIdentifier>));
            using var fs = new FileStream(Path, FileMode.Create);
            xs.Serialize(fs, _storage);
        }

        public bool Create(TIdentifier obj)
        {
            if (_storage.Any(t => t.Id == obj.Id)) return false;
            _storage.Add(obj);
            return true;
        }

        public TIdentifier Read(int id) => _storage.FirstOrDefault(t => t.Id == id);

        public TIdentifier Update(TIdentifier obj)
        {
            var index = _storage.FindIndex(t => t.Id == obj.Id);
            if (index == -1)
                Create(obj);
            else
                _storage[index] = obj;
            return obj;
        }

        public bool Delete(int objId)
        {
            return _storage.RemoveAll(t => t.Id == objId) != 0;
        }
    }
}
