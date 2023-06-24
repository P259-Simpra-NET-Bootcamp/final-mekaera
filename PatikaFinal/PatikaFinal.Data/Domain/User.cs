using PatikaFinal.Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFinal.Data.Domain
{
    public class User : BaseModel
    {
        //Kullanıcı (ad, soyad, email, role, şifre, statü, dijital cüzdan bilgileri, puan bakiyesi ,vs) 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public int Money { get; set; }
        public int Score { get; set; }

    }
}
