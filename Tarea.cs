namespace tp7;
public class Tarea
{
    private int idTarea;
    private string descripcionTarea;
    private int duracionTarea;
    //Constructor
    public Tarea(int idTarea, string descripcionTarea, int duracionTarea)
    {
        this.IdTarea = idTarea;
        this.DescripcionTarea = descripcionTarea;
        this.DuracionTarea = duracionTarea;
    }
    //Propiedades
    public int IdTarea { get => idTarea; set => idTarea = value; }
    public string DescripcionTarea { get => descripcionTarea; set => descripcionTarea = value; }
    public int DuracionTarea { get => duracionTarea; set => duracionTarea = value; }
    //Metodo pra mostrar tarea
    public void MostrarTarea()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Id de la tarea: " + IdTarea);
        Console.WriteLine("Descripcion de la tarea: " + DescripcionTarea);
        Console.WriteLine("Duracion de la tarea: " + DuracionTarea + " min");
        //Console.WriteLine("---------------------------------------------");
    }
}