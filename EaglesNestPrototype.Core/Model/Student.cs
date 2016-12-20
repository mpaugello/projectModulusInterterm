using SQLite;
using System;

namespace EaglesNestPrototype.Core.Model
{

    /**********************************************************************/
    /*                              PCC Student                           */
    /**********************************************************************/
    public class Student
    {
        [PrimaryKey]
        public int StudentId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        /* Student constructor                                            */
        public Student()
        {

        }
    }
}
