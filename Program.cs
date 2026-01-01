namespace _4_aspnetcore_controllers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers(); //aggiungi i controller
            var app = builder.Build();
            app.UseStaticFiles(); //per servire file statici
            app.UseRouting();
            app.MapControllers(); //mappa i controller
            app.Run();
        }

        

    }
}
