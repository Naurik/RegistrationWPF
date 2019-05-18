namespace Registration.DataAccess
{
    using Registration.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class RegistrationContext : DbContext
    {
        // Контекст настроен для использования строки подключения "RegistrationContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Registration.DataAccess.RegistrationContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "RegistrationContext" 
        // в файле конфигурации приложения.
        public RegistrationContext()
            : base("name=RegistrationContext")
        {
        }
        public DbSet<Users> User { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}