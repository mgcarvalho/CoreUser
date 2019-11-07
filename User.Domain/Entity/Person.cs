// <copyright file="Entity.cs" company="Academic Lab" >
//   Copyright (c) Marcelo Carvalho. All rights reserved.
// </copyright>
// <author>Marcelo Carvalho</author>
namespace User.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    using User.Domain.Enum;

    /// <summary>
    /// Person Entity
    /// </summary>
    public class Person : Entity
    {
        #region ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class
        /// </summary>
        public Person()
        {
            this.Id = new Guid();
            this.Birth = new DateTime();
        }

        public Person(Person person)
        {
            this.Id = new Guid();
            this.Name = person.Name;
            this.Email = person.Email;
            this.Birth = person.Birth;
        }

        public Person(Guid id, string name, string email, DateTime birth)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Birth = birth;
        }

        public Person(string name, string email, DateTime birth)
        {
            this.Id = new Guid();
            this.Name = name;
            this.Email = email;
            this.Birth = birth;
        }
        #endregion

        /// <summary>
        /// Gets or sets the name of user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email of user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the date of birth
        /// </summary>
        public DateTime Birth { get; set; }

        /// <summary>
        /// Gets or sets the roles of user
        /// </summary>
        public IEnumerable<EnumRole> Roles { get; set; }
    }
}
