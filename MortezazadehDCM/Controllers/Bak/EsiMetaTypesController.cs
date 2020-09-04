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

namespace MortezazadehDCM.Controllers.Bak
{
    public class EsiMetaTypesController : ApiController
    {
        private EME db = new EME();

        // GET: api/EsiMetaTypes
        public IQueryable<EsiToMetaType> GetEsiMetaTypes()
        {
            //  return db.EsiMetaTypes;
            return db.EsiMetaTypes.Select(x => new EsiToMetaType()
            {
                EsiMetaTypeId = x.EsiMetaTypeId,
                EsiMetaTypelabel = x.EsiMetaTypelabel
            });
        }

        //// GET: api/EsiMetaTypes/5n
        //[ResponseType(typeof(EsiMetaType))]
        //public async Task<IHttpActionResult> GetEsiMetaType(int id)
        //{
        //    EsiMetaType esiMetaType = await db.EsiMetaTypes.FindAsync(id);
        //    if (esiMetaType == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(esiMetaType);
        //}

        //// PUT: api/EsiMetaTypes/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutEsiMetaType(int id, EsiMetaType esiMetaType)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != esiMetaType.EsiMetaTypeId)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(esiMetaType).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EsiMetaTypeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/EsiMetaTypes
        //[ResponseType(typeof(EsiMetaType))]
        //public async Task<IHttpActionResult> PostEsiMetaType(EsiMetaType esiMetaType)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.EsiMetaTypes.Add(esiMetaType);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = esiMetaType.EsiMetaTypeId }, esiMetaType);
        //}

        //// DELETE: api/EsiMetaTypes/5
        //[ResponseType(typeof(EsiMetaType))]
        //public async Task<IHttpActionResult> DeleteEsiMetaType(int id)
        //{
        //    EsiMetaType esiMetaType = await db.EsiMetaTypes.FindAsync(id);
        //    if (esiMetaType == null)
        //    {
        //        return NotFound();
        //    }

        //    db.EsiMetaTypes.Remove(esiMetaType);
        //    await db.SaveChangesAsync();

        //    return Ok(esiMetaType);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool EsiMetaTypeExists(int id)
        //{
        //    return db.EsiMetaTypes.Count(e => e.EsiMetaTypeId == id) > 0;
        //}
    }
}