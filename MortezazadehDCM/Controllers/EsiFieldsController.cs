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
    public class EsiFieldsController : ApiController
    {
        private EME db = new EME();


        // GET: api/EsiFields
        //public IQueryable<EsiField> GetEsiFields()
        //{
        //    return db.EsiFields;
        //}
        // GET: api/EsiFields/5     
        //   [Route("EsiFields/{id}/")]


        [ResponseType(typeof(IQueryable<EsiToField>))]
        public async Task<IHttpActionResult> GetEsiField(decimal id)
        {

            //EsiField esiField = await db.EsiFields.FindAsync(id);
            //if (esiField == null)
            //{
            //    return NotFound();
            //}
            //return Ok(esiField);

            IQueryable<EsiToField> jj = db.EsiFields.Where(x => x.EsiCategory.CateID == id).Select(s => new EsiToField()
            {
                FieldID = s.FieldID,
                FieldLabel = s.FieldLabel,
                FieldType = s.FieldType,
                FieldSize = s.FieldSize     
                
                //fiels
            });

            //EsiItem esiItem = await db.EsiItems.
            //if (esiItem == null)
            //{
            //    return NotFound();
            //}

            return Ok(jj);



        }

        //// PUT: api/EsiFields/5
        //[ResponseType(typeof(void))]
        //public async Task<IHttpActionResult> PutEsiField(decimal id, EsiField esiField)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != esiField.FieldID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(esiField).State = EntityState.Modified;

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EsiFieldExists(id))
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

        //// POST: api/EsiFields
        //[ResponseType(typeof(EsiField))]
        //public async Task<IHttpActionResult> PostEsiField(EsiField esiField)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.EsiFields.Add(esiField);
        //    await db.SaveChangesAsync();

        //    return CreatedAtRoute("DefaultApi", new { id = esiField.FieldID }, esiField);
        //}

        //// DELETE: api/EsiFields/5
        //[ResponseType(typeof(EsiField))]
        //public async Task<IHttpActionResult> DeleteEsiField(decimal id)
        //{
        //    EsiField esiField = await db.EsiFields.FindAsync(id);
        //    if (esiField == null)
        //    {
        //        return NotFound();
        //    }

        //    db.EsiFields.Remove(esiField);
        //    await db.SaveChangesAsync();

        //    return Ok(esiField);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool EsiFieldExists(decimal id)
        //{
        //    return db.EsiFields.Count(e => e.FieldID == id) > 0;
        //}
    }
}