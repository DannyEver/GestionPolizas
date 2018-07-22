using DataAccessPoliza;
using DataAccessPoliza.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIPoliza.DTO;

namespace WebAPIPoliza.Controllers
{
    public class TipoRiesgoController : ApiController
    {
        IGenericRepository<TipoRiesgo> _repository = new GenericRepository<TipoRiesgo>();

        public List<TipoRiesgoDTO> GetTipoCubrimiento()
        {
            var tRiesgos = _repository.GetAll();

            List<TipoRiesgoDTO> listaRiesgo = new List<TipoRiesgoDTO>();

            foreach (var item in tRiesgos)
            {
                var tRiesgoDTO = new TipoRiesgoDTO();
                MapEntToDTO(ref tRiesgoDTO, item);
                listaRiesgo.Add(tRiesgoDTO);

            }

            return listaRiesgo;

        }

        private void MapEntToDTO(ref TipoRiesgoDTO tCubrimientoDTO, TipoRiesgo tCubrimiento)
        {
            tCubrimientoDTO.idRiesgo = tCubrimiento.idTipoRiesgo;
            tCubrimientoDTO.nombre = tCubrimiento.descripcionRiesgo;
        }
    }
}
