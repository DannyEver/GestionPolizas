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
    public class TipoCubrimientoController : ApiController
    {

        IGenericRepository<TipoCubrimiento> _repository = new GenericRepository<TipoCubrimiento>();

        public List<TipoCubrimientoDTO> GetTipoCubrimiento()
        {
            var tCubrimientos = _repository.GetAll();

            List<TipoCubrimientoDTO> listaCubrimientos = new List<TipoCubrimientoDTO>();

            foreach (var item in tCubrimientos)
            {
                var tCubrimientoDTO = new TipoCubrimientoDTO();
                MapEntToTCubrimientoDTO(ref tCubrimientoDTO, item);
                listaCubrimientos.Add(tCubrimientoDTO);

            }

            return listaCubrimientos;

        }

        private void MapEntToTCubrimientoDTO(ref TipoCubrimientoDTO tCubrimientoDTO, TipoCubrimiento tCubrimiento)
        {
            tCubrimientoDTO.idTCubrimiento = tCubrimiento.idCubrimiento;
            tCubrimientoDTO.nombre = tCubrimiento.nombre;
        }

    }
}
