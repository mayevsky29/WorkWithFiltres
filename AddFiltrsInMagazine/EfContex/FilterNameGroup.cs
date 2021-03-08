﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AddFiltrsInMagazine.EfContex
{
    [Table("tblFilterNameGroups")]
    public class FilterNameGroup
    {
        [ForeignKey("FilterNameOf"), Key, Column(Order = 0)] // Order визначає послідовність
        public int FilterNameId { get; set; }
        public virtual FilterName FilterNameOf { get; set; }

        [ForeignKey("FilterValueOf"), Key, Column(Order = 1)]
        public int FilterValueId { get; set; }
        public virtual FilterValue FilterValueOf { get; set; }
    }
}