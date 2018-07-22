using DataAccessPoliza;
using DataAccessPoliza.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPIPoliza.DTO;

namespace WebAPIPoliza.Controllers
{

    public class PolizaController : ApiController
    {
        private IGenericRepository<Poliza> _repository = new GenericRepository<Poliza>();       

        // GET: api/Poliza
        public List<PolizaDTO> GetPolizas()
        {
            var polizas = _repository.GetAll();

            List<PolizaDTO> listPoliza = new List<PolizaDTO>();

            foreach (var item in polizas)
            {
                var polizaDTO = new PolizaDTO();
                MapEntToDTO(ref polizaDTO, item);
                listPoliza.Add(polizaDTO);

            }

            return listPoliza;
        }

        // GET: api/Polizas/5
        [ResponseType(typeof(Poliza))]
        public PolizaDTO GetPoliza(int id)
        {
            Poliza poliza = _repository.Get(id);
            if (poliza == null)
            {
                return null;
            }

            var result = new PolizaDTO();
            MapEntToDTO(ref result, poliza);
            return result;
        }

        // PUT: api/Polizas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPoliza(int id, Poliza poliza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != poliza.idPoliza)
            {
                return BadRequest();
            }

            //db.Entry(poliza).State = EntityState.Modified;

            _repository.Edit(poliza);

            try
            {
                _repository.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PolizaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Polizas
        [ResponseType(typeof(Poliza))]
        public IHttpActionResult PostPoliza(Poliza poliza)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repository.Add(poliza);
            _repository.Save();

            return CreatedAtRoute("DefaultApi", new { id = poliza.idPoliza }, poliza);
        }

        // DELETE: api/Polizas/5
        [ResponseType(typeof(Poliza))]
        public IHttpActionResult DeletePoliza(int id)
        {
            Poliza poliza = _repository.Get(id);
            if (poliza == null)
            {
                return NotFound();
            }

            _repository.Delete(poliza);
            _repository.Save();

            return Ok(poliza);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repository._Context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PolizaExists(int id)
        {
            return _repository.Get(id) != null ? false : true;
        }

        private void MapEntToDTO(ref PolizaDTO result, Poliza poliza)
        {
            result.idPoliza = poliza.idPoliza;
            result.descripcion = poliza.descripcion;
            result.TipoCubrimiento = poliza.TipoCubrimiento.nombre;
            result.inicioVigencia = poliza.inicioVigencia;
            result.nombre = poliza.nombre;
            result.periodoCobertura = poliza.periodoCobertura;
            result.precio = poliza.precio;
            result.TipoRiesgo = poliza.TipoRiesgo.descripcionRiesgo;
        }
    }
}
