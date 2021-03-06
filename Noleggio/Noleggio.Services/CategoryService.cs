﻿using Noleggio.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noleggio.Data.Contracts;
using Noleggio.Services.Contracts;
using Noleggio.DtoModels;
using Noleggio.Common.Contracts;
using Bytes2you.Validation;

namespace Noleggio.Services
{
    public class CategoryService : NoleggioGenericService<Category>, ICategoryService
    {
        private IMapingService mapper;

        public CategoryService(IGenericEfRepository<Category> repository, IUnitOfWork unitOfWork, IMapingService mapper)
            : base(repository, unitOfWork)
        {
            Guard.WhenArgument(mapper, nameof(mapper)).IsNull().Throw();
            this.mapper = mapper;
        }
        public List<CategoryDtoModel> GetAllCategories()
        {
            var categories = base.GetAll().Where(x => !x.IsDeleted).ToList();
            return mapper.Map<List<CategoryDtoModel>>(categories).ToList();
        }
    }
}
