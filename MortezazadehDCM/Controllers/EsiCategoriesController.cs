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
using Newtonsoft.Json;

namespace MortezazadehDCM.Controllers
{
    public class EsiCategoriesController : ApiController
    {
        private EME db = new EME();

        // GET: api/EsiCategories
        public List<EsiToCategory> GetEsiCategories()
        {
            return db.EsiCategories.Select(x => new EsiToCategory() {
                CateID = x.CateID,
                CateDesc = x.CateDesc,
                CateLabel = x.CateLabel
            }).ToList();
          //  return db.EsiCategories;
        }

        // GET: api/EsiCategories/5
        [ResponseType(typeof(EsiCategory))]
        public async Task<IHttpActionResult> GetEsiCategory(decimal id)
        {
            EsiCategory esiCategory = await db.EsiCategories.FindAsync(id);
            if (esiCategory == null)
            {
                return NotFound();
            }

            return Ok(esiCategory);
        }

        // PUT: api/EsiCategories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEsiCategory(decimal id, EsiCategory esiCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != esiCategory.CateID)
            {
                return BadRequest();
            }

            db.Entry(esiCategory).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EsiCategoryExists(id))
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

        // POST: api/EsiCategories
        [ResponseType(typeof(EsiCategory))]
        public async Task<IHttpActionResult> PostEsiCategory(EsiCategory esiCategory)
        {

            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            // product = response.Content.
            //var sssss = response.Content.ReadAsStringAsync().Result;

            //  EsiCategory  esiCategory = JsonConvert.DeserializeObject<EsiCategory>(s);
            try
            {
                //db.Entry(esiCategory.EsiFields.Select(x => x.EsiMetaType)).State = System.Data.Entity.EntityState.Unchanged;

                using (var newContext = new EME())
                {
                    newContext.Entry(esiCategory).State = esiCategory.CateID
                        == 0 ? EntityState.Added : EntityState.Modified;

                    foreach (EsiField filed in esiCategory.EsiFields)
                    {
                        newContext.Entry(filed).State = filed.FieldID == 0 ? EntityState.Added : EntityState.Modified;
                        newContext.Entry(filed.EsiMetaType).State = EntityState.Unchanged;

                        //foreach (EsiMetaType meta in filed.EsiMetaType)
                        //    newContext.Entry(filed).State = filed.FieldID == 0 ? EntityState.Added : EntityState.Modified;
                    }
                    newContext.SaveChanges();
                }

                //  db.EsiCategories.Add(esiCategory);
                // await db.SaveChangesAsync();
            }
            catch (Exception e)
            {
            }

            //   db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = esiCategory.CateID }, esiCategory);
        }

        // DELETE: api/EsiCategories/5
        [ResponseType(typeof(EsiCategory))]
        public async Task<IHttpActionResult> DeleteEsiCategory(decimal id)
        {
            EsiCategory esiCategory = await db.EsiCategories.FindAsync(id);
            if (esiCategory == null)
            {
                return NotFound();
            }

            db.EsiCategories.Remove(esiCategory);
            await db.SaveChangesAsync();

            return Ok(esiCategory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EsiCategoryExists(decimal id)
        {
            return db.EsiCategories.Count(e => e.CateID == id) > 0;
        }
    }
}