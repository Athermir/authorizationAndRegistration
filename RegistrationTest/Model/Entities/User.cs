//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationTest.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {

        }
        public User(string login, string password, int role = 1) => (Login, Password, RoleId) = (login, password, role);

        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleId { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
