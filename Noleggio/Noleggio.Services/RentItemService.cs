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
using AutoMapper;

namespace Noleggio.Services
{
    public class RentItemService :  NoleggioGenericService<RentItem>, IRentItemService, IHaveCustomMappings
    {
        private IMapingService mapper;

        public RentItemService(IGenericEfRepository<RentItem> repository, IUnitOfWork unitOfWork, IMapingService mapper) 
            : base(repository, unitOfWork)
        {
            Guard.WhenArgument(mapper, nameof(mapper)).IsNull().Throw();
            this.mapper = mapper;
        }

        public void Add(RentItemDtoModel item)
        {
            
            base.Add(mapper.Map<RentItem>(item));
        }

       

        public void CreateMappings(IMapperConfigurationExpression config)
        {
            //config.CreateMap<RentItemDtoModel, RentItem>()
                //.ForMember(dest => dest.CategoryId, opt => opt.
        }

    }
}