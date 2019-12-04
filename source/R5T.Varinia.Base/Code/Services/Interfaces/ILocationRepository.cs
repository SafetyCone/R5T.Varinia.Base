using System;

using R5T.Corcyra;


namespace R5T.Varinia
{
    public interface ILocationRepository
    {
        LocationIdentity New();
        LocationIdentity New(LngLat lngLat);

        bool Exists(LocationIdentity identity);

        void SetLngLat(LocationIdentity identity, LngLat lngLat);
        LngLat GetLngLat(LocationIdentity identity);

        void Delete(LocationIdentity identity);
    }
}
