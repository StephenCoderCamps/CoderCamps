using MyApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services.Services
{
    public interface IProductService
    {
        void Add(FullProductDTO product);
        void Delete(int id);
        void Edit(FullProductDTO product);
        FullProductDTO Get(int id);
        IList<BriefProductDTO> List();
    }
}
