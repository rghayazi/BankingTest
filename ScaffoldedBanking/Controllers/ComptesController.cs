using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ScaffoldedBanking.Models;

namespace ScaffoldedBanking.Controllers
{
    public class ComptesController : ApiController
    {
        private BankingModel db = new BankingModel();

        // GET: api/Comptes
        public IQueryable<Compte> GetComptes()
        {
            return db.Comptes;
        }

        // GET: api/Comptes/5
        [ResponseType(typeof(Compte))]
        public IHttpActionResult GetCompte(string id)
        {
            Compte compte = db.Comptes.Find(id);
            if (compte == null)
            {
                return NotFound();
            }

            return Ok(compte);
        }

        // PUT: api/Comptes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompte(string id, Compte compte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != compte.Numero)
            {
                return BadRequest();
            }

            db.Entry(compte).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompteExists(id))
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

        // POST: api/Comptes
        [ResponseType(typeof(Compte))]
        public IHttpActionResult PostCompte(Compte compte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Comptes.Add(compte);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CompteExists(compte.Numero))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = compte.Numero }, compte);
        }

        // DELETE: api/Comptes/5
        [ResponseType(typeof(Compte))]
        public IHttpActionResult DeleteCompte(string id)
        {
            Compte compte = db.Comptes.Find(id);
            if (compte == null)
            {
                return NotFound();
            }

            db.Comptes.Remove(compte);
            db.SaveChanges();

            return Ok(compte);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CompteExists(string id)
        {
            return db.Comptes.Count(e => e.Numero == id) > 0;
        }
    }
}