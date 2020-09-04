using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using MortezazadehDCM.Models;

namespace MortezazadehDCM.Controllers
{
    [RoutePrefix("api/EsiItems")]
    public class EsiItemsController : ApiController
    {
        private EME db = new EME();

        // GET: api/EsiItems
        public IQueryable<EsiItem> GetEsiItems()
        {
            return db.EsiItems;
        }

        // GET: api/EsiItems/5
        [ResponseType(typeof(EsiItem))]
        public async Task<IHttpActionResult> GetEsiItem(decimal id)
        {
            EsiItem esiItem = await db.EsiItems.FindAsync(id);
            if (esiItem == null)
            {
                return NotFound();
            }

            return Ok(esiItem);
        }

        [Route("GetGateItems/{id}/")]
        [ResponseType(typeof(IQueryable<EsiToItem>))]
        public async Task<IHttpActionResult> GetGateItems(decimal id)
        {
            IQueryable<EsiToItem> jj = db.EsiItems.Where(x => x.EsiField.EsiCategory.CateID == id).Select(s=> new EsiToItem() {

                EsiFieldId = s.EsiFieldId,
                EsiObjId = s.EsiObjId,
                EsiStrVal = s.EsiStrVal
            });
            //EsiItem esiItem = await db.EsiItems.
            //if (esiItem == null)
            //{
            //    return NotFound();
            //}
            return Ok(jj);
        }

        // PUT: api/EsiItems/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEsiItem(decimal id, EsiItem esiItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != esiItem.EsiObjId)
            {
                return BadRequest();
            }

            db.Entry(esiItem).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EsiItemExists(id))
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

        // POST: api/EsiItems
        [ResponseType(typeof(EsiItem))]
        public async Task<IHttpActionResult> PostEsiItem(EsiItem esiItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EsiItems.Add(esiItem);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EsiItemExists(esiItem.EsiObjId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = esiItem.EsiObjId }, esiItem);
        }

        // DELETE: api/EsiItems/5
        [ResponseType(typeof(EsiItem))]
        public async Task<IHttpActionResult> DeleteEsiItem(decimal id)
        {
            EsiItem esiItem = await db.EsiItems.FindAsync(id);
            if (esiItem == null)
            {
                return NotFound();
            }

            db.EsiItems.Remove(esiItem);
            await db.SaveChangesAsync();

            return Ok(esiItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EsiItemExists(decimal id)
        {
            return db.EsiItems.Count(e => e.EsiObjId == id) > 0;
        }
    }
}