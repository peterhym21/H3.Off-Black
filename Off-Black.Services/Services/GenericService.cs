using Off_Black.Interfaces;
using Off_Black.Services.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Off_Black.Services.Services
{
    /// <summary>
    /// Generic service
    /// </summary>
    /// <typeparam name="X">The class type</typeparam>
    public abstract class GenericService<X, Y, Z> : BaseService, IGenericService<X> where X : class where Y : IGenericRepository<Z> where Z : class

    {
        private readonly Y _genericRepository;
        private readonly MappingService _mappingService;
        private readonly string _entityName = typeof(Z).ToString().Replace("VikingBOMDK.Repository.Entities.", "");

        public GenericService(Y GenericRepository, MappingService mappingService)
        {
            _genericRepository = GenericRepository;
            _mappingService = mappingService;
        }

        /// <summary>
        /// Adds a new <paramref name="entity"/> to the database
        /// </summary>
        public async Task Create(X entity)
        {
            try
            {
                await _genericRepository.Create(_mappingService._mapper.Map<Z>(entity));
                LogInformation($"Successfully created a new {_entityName}");
            }
            catch (Exception e)
            {
                LogError($"Failed to create a new {_entityName}", e);
            }
        }

        /// <summary>
        /// Removes an existing <paramref name="entity"/> from the database
        /// </summary>
        public async Task Delete(X entity)
        {
            try
            {
                await _genericRepository.Delete(_mappingService._mapper.Map<Z>(entity));
                LogInformation($"Successfully deleted a {_entityName}");
            }
            catch (Exception e)
            {
                LogError($"Failed to delete a {_entityName}", e);
            }
        }


        /// <summary>
        /// Gets a list of all the <typeparamref name="X"/> entities from the database
        /// </summary>
        public async Task<List<X>> GetAll()
        {
            try
            {
                List<X> tempList = _mappingService._mapper.Map<List<X>>(await _genericRepository.GetAll());
                LogInformation($"Successfully fetched a list of {_entityName}s");
                return tempList;
            }
            catch (Exception e)
            {
                LogError($"Failed to fetch a list of {_entityName}s", e);
                return new List<X>();
            }
        }

        /// <summary>
        /// Updates an existing <paramref name="entity"/> in the database
        /// </summary>
        public async Task Update(X entity)
        {
            try
            {
                await _genericRepository.Update(_mappingService._mapper.Map<Z>(entity));
                LogInformation($"Successfully updated a {_entityName}");
            }
            catch (Exception e)
            {
                LogError($"Failed to updated a {_entityName}", e);
            }
        }
    }
}
