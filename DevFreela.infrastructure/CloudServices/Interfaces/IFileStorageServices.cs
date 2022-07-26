using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.infrastructure.CloudServices.Interfaces
{
    public interface IFileStorageServices
    {
        void UploadFile(byte[] bytes, string fileName);
    }
}
