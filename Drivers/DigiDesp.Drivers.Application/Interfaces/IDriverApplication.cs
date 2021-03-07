using System.Threading.Tasks;
using DigiDesp.Drivers.Application.Dto;

namespace DigiDesp.Drivers.Application.Interfaces
{
    public interface IDriverApplication
    {
         Task RegisterDriver(DriverDto driver);
    }
}