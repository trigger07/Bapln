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
    public class DonadorDAO
    {
        public List<DonadorDTO> ObtenerDonadores()
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from donador in entities.LIS_Donador
                            join nacionalidad in entities.CAT_Nacionalidad
                            on donador.Id_Nacionalidad equals nacionalidad.Id
                            join periodicidad in entities.CAT_PeriodicidadPago
                            on donador.Id_Periodicidad equals periodicidad.Id
                            select new DonadorDTO
                            {
                                Id = donador.Id,
	                            Nombre = donador.Nombre,
	                            PrimerApellido = donador.PrimerApellido,
	                            SegundoApellido = donador.SegundoApellido,
	                            Email = donador.Email,
	                            TelefonoLocal = donador.TelefonoLocal,
	                            TelefonoMovil = donador.TelefonoLocal,
	                            Id_Periodicidad = donador.Id_Periodicidad,
                                Periodicidad = periodicidad.Descripcion,
	                            MontoAporte = donador.MontoAporte,
                                Id_Nacionalidad = donador.Id_Nacionalidad,
	                            Nacionalidad = nacionalidad.Descripcion,
	                            FechaNacimiento = donador.FechaNacimiento,
                                Activo = donador.Activo

                            };
                return query.ToList();
            }
        }

        public DonadorDTO ObtenerDonador(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                var query = from donador in entities.LIS_Donador
                            join nacionalidad in entities.CAT_Nacionalidad
                            on donador.Id_Nacionalidad equals nacionalidad.Id
                            join periodicidad in entities.CAT_PeriodicidadPago
                            on donador.Id_Periodicidad equals periodicidad.Id
                            where donador.Id == id
                            select new DonadorDTO
                            {
                                Id = donador.Id,
                                Nombre = donador.Nombre,
                                PrimerApellido = donador.PrimerApellido,
                                SegundoApellido = donador.SegundoApellido,
                                Email = donador.Email,
                                TelefonoLocal = donador.TelefonoLocal,
                                TelefonoMovil = donador.TelefonoLocal,
                                Id_Periodicidad = donador.Id_Periodicidad,
                                Periodicidad = periodicidad.Descripcion,
                                MontoAporte = donador.MontoAporte,
                                Id_Nacionalidad = donador.Id_Nacionalidad,
                                Nacionalidad = nacionalidad.Descripcion,
                                FechaNacimiento = donador.FechaNacimiento,
                                Activo = donador.Activo
                            };
                return query.First();
            }
        }

        public void CrearDonador(DonadorDTO donador)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                LIS_Donador lisDonador = new LIS_Donador
                {
                    Id = donador.Id,
                    Nombre = donador.Nombre,
                    PrimerApellido = donador.PrimerApellido,
                    SegundoApellido = donador.SegundoApellido,
                    Email = donador.Email,
                    TelefonoLocal = donador.TelefonoLocal,
                    TelefonoMovil = donador.TelefonoLocal,
                    Id_Periodicidad = donador.Id_Periodicidad,
                    MontoAporte = donador.MontoAporte,
                    Id_Nacionalidad = donador.Id_Nacionalidad,
                    FechaNacimiento = donador.FechaNacimiento,
                    Activo = true
                };

                entities.LIS_Donador.Add(lisDonador);
                entities.SaveChanges();
            }
        }

        public void InactivarDonador(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                LIS_Donador donador = entities.LIS_Donador.Find(id);
                donador.Activo = false;

                entities.SaveChanges();
            }
        }

        public void ActivarDonador(int id)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                LIS_Donador donador = entities.LIS_Donador.Find(id);
                donador.Activo = true;

                entities.SaveChanges();
            }
        }

        public bool ActualizarDonador(DonadorDTO donador)
        {
            using (BAPLNEntities entities = new BAPLNEntities())
            {
                LIS_Donador lisDonador = entities.LIS_Donador.Find(donador.Id);
                lisDonador.Nombre = donador.Nombre;
                lisDonador.PrimerApellido = donador.PrimerApellido;
                lisDonador.SegundoApellido = donador.SegundoApellido;
                lisDonador.Email = donador.Email;
                lisDonador.TelefonoLocal = donador.TelefonoLocal;
                lisDonador.TelefonoMovil = donador.TelefonoLocal;
                lisDonador.Id_Periodicidad = donador.Id_Periodicidad;
                lisDonador.MontoAporte = donador.MontoAporte;
                lisDonador.Id_Nacionalidad = donador.Id_Nacionalidad;
                lisDonador.FechaNacimiento = donador.FechaNacimiento;
                lisDonador.Activo = donador.Activo;
                entities.SaveChanges();
            }
            return true;
        }
    }
}
