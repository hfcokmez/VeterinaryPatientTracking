using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Patient: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Owner { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Diagnosis { get; set; }
    }
}
