﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Corcyra;

using R5T.T0064;


namespace R5T.Varinia
{
    [ServiceDefinitionMarker]
    public interface ILocationRepository : IServiceDefinition
    {
        Task<LocationIdentity> New();
        Task<LocationIdentity> New(LngLat lngLat);

        Task<bool> Exists(LocationIdentity identity);

        Task SetLngLat(LocationIdentity identity, LngLat lngLat);
        Task<LngLat> GetLngLat(LocationIdentity identity);

        Task Delete(LocationIdentity identity);

        Task<List<Location>> GetAllWithinBoundingBox(BoundingBox boundingBox);
    }
}
