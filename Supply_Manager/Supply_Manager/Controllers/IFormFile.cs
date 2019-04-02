using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Supply_Manager.Controllers
{
    public interface IFormFile
    {
        int Length { get; set; }

        Task CopyToAsync(FileStream stream);
        Task CopyToAsync(Stream target);
    }
}
