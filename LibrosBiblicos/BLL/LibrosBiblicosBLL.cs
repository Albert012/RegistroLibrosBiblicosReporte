using LibrosBiblicos.DAL;
using LibrosBiblicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LibrosBiblicos.BLL
{
    public class LibrosBiblicosBLL
    {
        public static bool Guardar(LibrosBiblia libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Libros.Add(libro) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(LibrosBiblia libro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(libro).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch(Exception)

            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                LibrosBiblia libro = contexto.Libros.Find(id);
                contexto.Libros.Remove(libro);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }

        public static LibrosBiblia Buscar(int id)
        {
            Contexto contexto = new Contexto();
            LibrosBiblia libro = new LibrosBiblia();

            try
            {
                libro = contexto.Libros.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return libro;
        }

        public static List<LibrosBiblia> GetList(Expression<Func<LibrosBiblia, bool>> expression)
        {
            List<LibrosBiblia> libro = new List<LibrosBiblia>();
            Contexto contexto = new Contexto();

            try
            {
                libro = contexto.Libros.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return libro;
        }

    }
}
