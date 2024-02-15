using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        // ptt manager olarak başka bir sınıfa ihtiyaç duuyorum o sınıfı newlemek yerine onun interfacesini alıyorum

       private IApplicantService _applicationService;
        // IApplicantService _applicationServiceForeigner = new ForeignerManager();


        // constructor new yapıldığında çalışır.
        public PttManager(IApplicantService applicationService)
        { 
            _applicationService = applicationService;
        }

        // PTT maskeyi dağıtan kuruluş GiveMask kullan

        public void GiveMask(Person person)
        {
            if (_applicationService.CheckPerson(person) == true )
            {
                Console.WriteLine("Mask was given to " + person.FirstName + " " + person.LastName);
            }else { Console.WriteLine("Mask could not be given "); }
           
        }

        public void GiveMask()
        {
            throw new NotImplementedException();
        }
    }
}
