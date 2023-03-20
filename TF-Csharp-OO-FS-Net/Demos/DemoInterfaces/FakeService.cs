using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos.Interfaces
{
    public class Livre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
    public interface IFakeService
    {
        void Add(Livre l);
        void Remove(Livre l);
        void Update (Livre l);
        Livre GetById(int id);
        List<Livre> GetAll();
    }
    public class FakeService : IFakeService
    {
        public void Add(Livre l)
        {
            throw new NotImplementedException();
        }

        public List<Livre> GetAll()
        {
            throw new NotImplementedException();
        }

        public Livre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Livre l)
        {
            throw new NotImplementedException();
        }

        public void Update(Livre l)
        {
            throw new NotImplementedException();
        }
    }
}
