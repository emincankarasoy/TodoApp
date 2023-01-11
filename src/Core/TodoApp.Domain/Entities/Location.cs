using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities.Common;

namespace TodoApp.Domain.Entities
{
    public class Location : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Latitude { get; set; } = string.Empty;

        public string Longtitude { get; set; } = string.Empty;

        public string Elevation { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public Task Task { get; set; }
    }
}
