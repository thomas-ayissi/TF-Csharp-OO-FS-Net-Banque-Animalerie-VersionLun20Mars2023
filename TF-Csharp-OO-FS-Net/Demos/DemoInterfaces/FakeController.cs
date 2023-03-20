using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF_Csharp_OO_FS_Net.Demos.Interfaces
{
    public class FakeController
    {
        private IFakeService _fakeService;
        public FakeController(IFakeService fakeService)
        {
            _fakeService = fakeService;
        }

        public void Add(Livre l)
        {
            _fakeService.Add(l);
        }
        public void Remove(Livre l)
        {
            _fakeService.Remove(l);
        }
        public void Update(Livre l)
        {
            _fakeService.Update(l);
        }
        public Livre GetById(int id)
        {
            return _fakeService.GetById(id);
        }
        public List<Livre> GetAll()
        {
            return _fakeService.GetAll();
        }
    }
}
