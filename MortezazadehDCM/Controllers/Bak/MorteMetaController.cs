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
using MortezazadehDCM;
using System.Web;
using Newtonsoft.Json;
using MortezazadehDCM.Models;
namespace MortezazadehDCM.Controllers.Bak
{

  //  [RoutePrefix("api/MorteMeta")]
    public class MorteMetaController 
    {

    //    private EME db = new EME();

    //    [Route("GetEsiCategories")]
    //    public IQueryable<EsiCategory> GetEsiCategories()
    //    {

    //        //string json = JsonConvert.SerializeObject(db.EsiCategories);



    //        //string sss = JsonConvert.SerializeObject(db.EsiCategories, Formatting.None,
    //        //             new JsonSerializerSettings()
    //        //             {
    //        //                 ReferenceLoopHandling = ReferenceLoopHandling.Ignore
    //        //             });


    //        //string ss = JsonConvert.SerializeObject(db.EsiCategories.Select(x => new { x.CateName, x.CateLabel }), Formatting.Indented,
    //        //          new JsonSerializerSettings()
    //        //          {
    //        //              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
    //        //          });

    //        //string s = JsonConvert.SerializeObject(db.ViewCates, Formatting.Indented,
    //        //          new JsonSerializerSettings()
    //        //          {
    //        //              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
    //        //          });






    //        return db.EsiCategories;
          
    //    }

    //    [Route("GetEsiCategory")]
    //    [ResponseType(typeof(EsiCategory))]
    //    public async Task<IHttpActionResult> GetEsiCategory(decimal id)
    //    {
    //        EsiCategory esiCategory = await db.EsiCategories.FindAsync(id);
    //        if (esiCategory == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(esiCategory);
    //    }


    //    // $"api/products/{id}"
    //    [HttpGet]
    //    [Route("GetGateItems/{id}")]
        
    //    [ResponseType(typeof(IQueryable<EsiItem>))]
    //    public async Task<IHttpActionResult> GetGateItems(decimal id)
    //    {

    //      //  int id = int.Parse(sid);
    //        IQueryable<EsiItem> jj = db.EsiItems.Where(x => x.EsiObjId == id);

    //        //EsiItem esiItem = await db.EsiItems.
    //        //if (esiItem == null)
    //        //{
    //        //    return NotFound();
    //        //}

    //        return Ok(jj);
    //    }


    }
}
