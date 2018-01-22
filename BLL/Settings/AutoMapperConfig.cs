using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Settings
{
    /// <summary>
    /// class for automapper configuration
    /// </summary>
    public class AutoMapperConfig
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Item, ItemDTO>();
                cfg.CreateMap<ItemDTO, Item>();
            });
        }
    }
}
