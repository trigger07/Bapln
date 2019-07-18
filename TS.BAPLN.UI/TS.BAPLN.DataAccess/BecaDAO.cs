using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.BAPLN.DataEntities;
using TS.BAPLN.DataEntities.DTO;
using TS.BAPLN.DataModel;

namespace TS.BAPLN.DataAccess
{
    public class BecaDAO
    {
        public List<BecaDTO> ObtenerBecas()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from beca in entities.CAT_Beca
                            join tipoBeca in entities.CAT_TipoBeca
                            on beca.Id_TipoBeca equals tipoBeca.Id
                            select new BecaDTO
                            {
                                Id = beca.Id,
                                Descripcion = beca.Descripcion,
                                Id_TipoBeca = beca.Id_TipoBeca,
                                TipoBeca = tipoBeca.Descripcion,
                                MontoTotal = beca.MontoTotal,
                                MontoCuota = beca.MontoCuota,
                                CantidadCuotas = beca.CantidadCuotas,
                                Activa = beca.Activa
                            };
                return query.ToList<BecaDTO>();
            }
        }

        public List<BecaDTO> ObtenerBecasActivas()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from beca in entities.CAT_Beca
                            join tipoBeca in entities.CAT_TipoBeca
                            on beca.Id_TipoBeca equals tipoBeca.Id
                            where beca.Activa == true
                            select new BecaDTO
                            {
                                Id = beca.Id,
                                Descripcion = beca.Descripcion,
                                Id_TipoBeca = beca.Id_TipoBeca,
                                TipoBeca = tipoBeca.Descripcion,
                                MontoTotal = beca.MontoTotal,
                                MontoCuota = beca.MontoCuota,
                                CantidadCuotas = beca.CantidadCuotas,
                                Activa = beca.Activa
                            };
                return query.ToList<BecaDTO>();
            }
        }

        public BecaDTO ObtenerBecaPorId(int id)
        {
            using (BAPLNEntities db = new BAPLNEntities())
            {
                var query = from beca in db.CAT_Beca
                            join tipoBeca in db.CAT_TipoBeca
                            on beca.Id_TipoBeca equals tipoBeca.Id
                            where beca.Id == id
                            select new BecaDTO
                            {
                                Id = beca.Id,
                                Descripcion = beca.Descripcion,
                                Id_TipoBeca = beca.Id_TipoBeca,
                                TipoBeca = tipoBeca.Descripcion,
                                MontoTotal = beca.MontoTotal,
                                MontoCuota = beca.MontoCuota,
                                CantidadCuotas = beca.CantidadCuotas,
                                Activa = beca.Activa
                            };
                return query.First();
            }
        }

        public void Inactivar(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_Beca b = entities.CAT_Beca.Find(id);
                b.Activa = false;

                entities.SaveChanges();
            }
        }

        public void Activar(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                CAT_Beca b = entities.CAT_Beca.Find(id);
                b.Activa = true;

                entities.SaveChanges();
            }
        }

        public void CrearBeca(BecaDTO beca)
        {
            using(BAPLNEntities db = new BAPLNEntities())
            {
                CAT_Beca CatBeca = new CAT_Beca
                {
                    Descripcion = beca.Descripcion,
                    Id_TipoBeca = beca.Id_TipoBeca,
                    MontoTotal = beca.MontoTotal,
                    MontoCuota = beca.MontoCuota,
                    CantidadCuotas = beca.CantidadCuotas,
                    Activa = true
                };

                db.CAT_Beca.Add(CatBeca);
                db.SaveChanges();
            }
        }

        public bool ActualizarBeca(BecaDTO beca)
        {
            using(BAPLNEntities db = new BAPLNEntities())
            {
                CAT_Beca catBeca = db.CAT_Beca.Find(beca.Id);
                catBeca.Descripcion = beca.Descripcion;
                catBeca.Id_TipoBeca = beca.Id_TipoBeca;
                catBeca.MontoTotal = beca.MontoTotal;
                catBeca.MontoCuota = beca.MontoCuota;
                catBeca.CantidadCuotas = beca.CantidadCuotas;
                catBeca.Activa = beca.Activa;
                db.SaveChanges();
            }

            return true;
        }
    }
}
