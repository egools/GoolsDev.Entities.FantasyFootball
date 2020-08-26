﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FantasyComponents
{
    [Table("Managers")]
    public class Manager
    {
        [Key]
        public int ManagerId { get; }
        public string Name { get; }
        public int YearJoined { get; }
        
            
    }
}
