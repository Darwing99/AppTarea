using AppTarea.clases;
using AppTarea.model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppTarea
    .clases
{
    class Crud
    {
        Conexion conn = new Conexion();



        public Task<List<Imagen>> getReadUbicacion()
        {
            return conn.GetConnectionAsync().Table<Imagen>().ToListAsync();
        }

        public Task<Imagen> getUbicacionId(int id)
        {
            return conn
                .GetConnectionAsync()
                .Table<Imagen>()
                .Where(item => item.id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> getUbicacionUpdateId(Imagen ubicacion)
        {
            return conn
                .GetConnectionAsync()
                .UpdateAsync(ubicacion);

        }

        public Task<int> Delete(Imagen ubicacion)
        {
            return conn
                .GetConnectionAsync()
                .DeleteAsync(ubicacion);
        }
    }
}
