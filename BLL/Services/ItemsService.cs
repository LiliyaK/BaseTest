using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Repository;
using AutoMapper;
using DAL.Entities;
using Core.Infrastructure;

namespace BLL.Services
{
    /// <summary>
    /// class for editing items from file
    /// </summary>
    /// <seealso cref="BLL.Interfaces.IItemService" />
    public class ItemsService : IItemService
    {
        /// <summary>
        /// The item repository
        /// </summary>
        private IRepository itemRepository;
        /// <summary>
        /// The file service
        /// </summary>
        private IFileService fileService;
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsService"/> class.
        /// </summary>
        /// <param name="root">The root.</param>
        public ItemsService(string root)
        {
            this.fileService = new FileService(root);
            this.itemRepository = new ItemRepository(Mapper.Map<IEnumerable<ItemDTO>, IEnumerable<Item>>(fileService.Read()));
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public List<ItemDTO> GetAll()
        {
            return Mapper.Map<List<Item>, List<ItemDTO>>(itemRepository.items);
        }
        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <exception cref="ValidationException">Item is not initialized</exception>
        public void Add(ItemDTO item)
        {
            if (item == null)
            {
                throw new ValidationException("Item is not initialized", System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            itemRepository.Add(Mapper.Map<ItemDTO, Item>(item));
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="ValidationException">Item is not initialized</exception>
        public void Delete(ItemDTO item)
        {
            if (item == null)
            {
                throw new ValidationException("Item is not initialized", System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
            this.itemRepository.Delete(Mapper.Map<ItemDTO, Item>(item));
        }
        /// <summary>
        /// Saves the specified is converted.
        /// </summary>
        /// <param name="IsConverted">if set to <c>true</c> [is converted].</param>
        public void Save(bool IsConverted)
        {
            fileService.Write(Mapper.Map <IEnumerable<Item>,IEnumerable<ItemDTO>> (itemRepository.items),IsConverted);
        }
    }
}
