using Elipses.Entidades;

namespace Elipses.Datos
{
    public class RepositorioElipses
    {
        private readonly char separatorChar = '|';
        private string archivo = "Productos.txt";
        private string RutaTrabajo = AppDomain.CurrentDomain.BaseDirectory;
        private List<Elipse>? elipse;
        public RepositorioElipses()
        {
            elipse = new List<Elipse>();
            LeerDatos();

        }

        private void LeerDatos()
        {
            var rutaArchivo = Path.Combine(RutaTrabajo, archivo);
            if (!File.Exists(rutaArchivo)) return;
            using (var lector = new StreamReader(rutaArchivo))
            {
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine()!;
                   
                    
                }
            }
        }

       

        public int GetCantidad()
        {
            return elipse!.Count;

        }
       
        internal void SetElipse(Elipse? p)
        {
            elipse = p;
        }
        public void Agregar(Elipse elipses)
        {
            elipse!.Add(elipses);
        }

        public void GuardarDatos()
        {
            var rutaArchivo = Path.Combine(RutaTrabajo, archivo);
            using (var escritor = new StreamWriter(rutaArchivo))
            {
                foreach (var productos in elipse!)
                {
                    string linea = ConstruirLinea(productos);
                    escritor.WriteLine(linea);
                }
            }
        }

        private string ConstruirLinea(Elipse elipse)
        {
            return $"{elipse.SemiejeMayor}| {elipse.SemiejeMenor} | {elipse.Color}|{elipse.Borde}";
        }

        public void Borrar(Elipse elipses)
        {
           elipse!.Remove(elipses);
        }

        
    }
}
