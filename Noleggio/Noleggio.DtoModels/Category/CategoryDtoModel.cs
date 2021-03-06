﻿using Noleggio.Common;
using Noleggio.Common.Contracts;
using Noleggio.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noleggio.DtoModels
{
    public class CategoryDtoModel: IMapFrom<Category>
    {
        public Guid ID { get; set; }

        //public string Image { get;  set;}

        [Required]
        [MinLength(NoleggioConstants.CategoryNameMinLenght)]
        [MaxLength(NoleggioConstants.CategoryNameMaxLenght)]
        [Display(Name = "Тип Категория")]
        public string Name { get; set; }
    }
}
