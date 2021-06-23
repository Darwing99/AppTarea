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



        public Task<List<Imagen>> getReadImage()
        {
            return conn.GetConnectionAsync().Table<Imagen>().ToListAsync();
        }

        public Task<Imagen> getImageId(int id)
        {
            return conn
                .GetConnectionAsync()
                .Table<Imagen>()
                .Where(item => item.id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> getImageUpdateId(Imagen image)
        {
            return conn
                .GetConnectionAsync()
                .UpdateAsync(image);

        }

        public Task<int> Delete(Imagen image)
        {
            return conn
                .GetConnectionAsync()
                .DeleteAsync(image);
        }
    }
}
