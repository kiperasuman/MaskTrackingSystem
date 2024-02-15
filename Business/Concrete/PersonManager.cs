using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference1;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        //Encapsulation
        public void ApplyForMask(Person person)
        {
            person.DateOfBirthYear = 1988;

        }
        public List<Person> GetAllPerson()
        {
            return null;
        }
        // kişi bilgilerinin kontrol edildiği metor
        public bool CheckPerson(Person person)
        {
            // mernis kontrolü yapar

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                   new TCKimlikNoDogrulaRequestBody(person.NationalId, person.FirstName, person.LastName, person.DateOfBirthYear)))
                   .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
