using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using Xamarin.Forms;

namespace GimnasioBarsAPP.Models
{
    public class Usuario
    {
        public RestRequest Request { get; set; }
        const string MimeType = "application/json";
        const string ContentType = "Content-Type";


        public Usuario() {


       }

        public string Nombre { get; set; } = null;
        public string CorreoElectronico { get; set; } = null;
        public string Contraseña { get; set; } = null;
        public string UserRoles { get; set; }
        public string UserStatusId { get; set; }
        public int? UserId { get; set; }
        public int? IdUserRole { get; set; }

        
       






    }






}






    

