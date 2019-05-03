using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public abstract class BaseEntity
    {
        private DateTime dateTime;
        [NotMapped]
        public DateTime UsedTime { get { this.dateTime = DateTime.Now; return dateTime; } set { } }
        public void WriteLog()
        {
            Console.WriteLine("".PadRight(40, '*'));
            Console.WriteLine("Log is written!");
            Console.WriteLine($"UseTime: {UsedTime.ToLongDateString()}");
            Console.WriteLine("".PadRight(40, '*'));
        }
    }
}
