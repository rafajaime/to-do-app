using System.Data.SQLite;
using To_Do_App.Models;
using To_Do_App.UI.User_Controls;

namespace To_Do_App.Data_Access_Obj
{
    public static class ClaseNotaDAO
    {
        public static string documentsPath = Environment.GetFolderPath(Environment.
            SpecialFolder.MyDocuments);
        public static string customPath = ("\\rafajaime\\Notas\\");
        public static string fullPath = documentsPath + customPath + "notasDB.db";
        public static string stringConexion = $"DataSource={fullPath};Version=3";
        public static void InicializarDB()
        {
            System.IO.Directory.CreateDirectory(documentsPath + customPath);
            if(!File.Exists(documentsPath + customPath + "notasDB.db"))
            {
                SQLiteConnection.CreateFile(documentsPath + customPath + "notasDB.db");
                UI_API.NuevoFormNotification("EXITO", "File creado con exito");
                CrearTablaNotas();
                UI_API.NuevoFormNotification("EXITO", "Tabla creada con exito");
                CrearTablaSettingsYConfigs();
                UI_API.NuevoFormNotification("EXITO", "Tabla creada con exito");
            }
            else
            {
                UI_API.NuevoFormNotification("INFO", "Base de datos encontrada");
            }
        }

        public static SQLiteConnection Conectar()
        {
            SQLiteConnection conexion = new SQLiteConnection(stringConexion);

            return conexion;
        }

        public static void CrearTablaNotas()
        {
            string crearTablaNotasQuery =
            "CREATE TABLE IF NOT EXISTS notas(id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, titulo VARCHAR(28) NULL, descripcion TEXT NOT NULL, completado INTEGER(2) DEFAULT '0');";

            SQLiteCommand comando = new SQLiteCommand();
            comando.CommandText = crearTablaNotasQuery;
            comando.Connection = Conectar();
            comando.Connection.Open();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public static void CrearTablaSettingsYConfigs()
        {
            //Se crea la tabla
            string crearTablaSettingsQuery =
            "CREATE TABLE IF NOT EXISTS settings(id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, darkmode INTEGER(2) DEFAULT '1');";

            SQLiteCommand comandoCreacion = new SQLiteCommand();
            comandoCreacion.CommandText = crearTablaSettingsQuery;
            comandoCreacion.Connection = Conectar();
            comandoCreacion.Connection.Open();
            comandoCreacion.ExecuteNonQuery();

            comandoCreacion.Connection.Close();


            //Se crean los valores default de configuracion
            string insertarSettingsQuery =
            $"INSERT INTO settings(darkmode) VALUES('1');";
            SQLiteCommand comandoInsertar = new SQLiteCommand();
            comandoInsertar.CommandText = insertarSettingsQuery;
            comandoInsertar.Connection = Conectar();
            comandoInsertar.Connection.Open();
            comandoInsertar.ExecuteNonQuery();

            comandoInsertar.Connection.Close();
        }
        public static void ConseguirSettings()
        {
            string querySettings =
            $"SELECT * FROM settings;";

            SQLiteCommand comando = new SQLiteCommand();
            comando.CommandText = querySettings;
            comando.Connection = Conectar();
            comando.Connection.Open();

            int darkMode = -1;

            SQLiteDataReader dataReader = comando.ExecuteReader();
            while(dataReader.Read())
            {
                darkMode = dataReader.GetInt16(1);
            }

            if(darkMode == 1)
            {
                UI_API.ActivarUIMode("dark");
            }
            else if(darkMode == 0)
            {
                UI_API.ActivarUIMode("light");
            }
            else
            {
                MessageBox.Show("Error, UIMode desconocido en Clase DAO");
            }

            comando.Connection.Close();
        }
        public static void ModificarSettings(string stringdarkmode)
        {
            int darkmode = -1;
            if(stringdarkmode == "dark")
            {
                darkmode = 1;
            }
            else if(stringdarkmode == "light")
            {
                darkmode = 0;
            }

            string modificarSettingsQuery =
            $"UPDATE settings SET darkmode = '{darkmode}';";

            SQLiteCommand comando = new SQLiteCommand();
            comando.CommandText = modificarSettingsQuery;
            comando.Connection = Conectar();
            comando.Connection.Open();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public static void InsertarNotaEnDB(string titulo, string descripcion)
        {
            string insertarNotaQuery =
                $"INSERT INTO notas(titulo, descripcion) VALUES('{titulo}', '{descripcion}');";

            SQLiteCommand comando = new SQLiteCommand();
            comando.CommandText = insertarNotaQuery;
            comando.Connection = Conectar();
            comando.Connection.Open();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public static void ModificarNotaEnDB(string titulo, string descripcion, int? id)
        {
            string insertarNotaQuery =
            $"UPDATE notas SET titulo = '{titulo}', descripcion = '{descripcion}' WHERE id = '{id}';";

            SQLiteCommand comando = new SQLiteCommand();
            comando.CommandText = insertarNotaQuery;
            comando.Connection = Conectar();
            comando.Connection.Open();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public static ItemNota ConseguirTituloYDescripcion(int? id)
        {
            string queryTituloYDesc =
            $"SELECT * FROM notas WHERE ID = '{id}';";

            SQLiteCommand comando = new SQLiteCommand();
            comando.CommandText = queryTituloYDesc;
            comando.Connection = Conectar();
            comando.Connection.Open();

            SQLiteDataReader dataReader = comando.ExecuteReader();

            ItemNota nota = new ItemNota();

            while (dataReader.Read())
            {
                nota.Id = dataReader.GetInt32(0);
                nota.Titulo = dataReader.GetString(1);
                nota.Descripcion = dataReader.GetString(2);
            }

            comando.Connection.Close();
            return nota;
        }

        public static void ModificarEstaCompletado(int? id, int wasCompleted)
        {
            string modificarCompletadoQuery =
            $"UPDATE notas SET completado = '{wasCompleted}' WHERE id = '{id}';";

            SQLiteCommand comando = new SQLiteCommand();
            comando.CommandText = modificarCompletadoQuery;
            comando.Connection = Conectar();
            comando.Connection.Open();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public static void BorrarNotaEnDB(int? id)
        {
            string borrarNotaQuery =
                $"DELETE FROM notas WHERE id = '{id}';";

            SQLiteCommand comando = new SQLiteCommand();
            comando.CommandText = borrarNotaQuery;
            comando.Connection = Conectar();
            comando.Connection.Open();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public static List<ItemNota> ConseguirEntriesDB()
        {
            string queryDeDatos = "SELECT * FROM notas;";

            SQLiteCommand comando = new SQLiteCommand();
            comando.CommandText = queryDeDatos;
            comando.Connection = Conectar();
            comando.Connection.Open();

            List<ItemNota> lista = new List<ItemNota>();

            SQLiteDataReader dataReader = comando.ExecuteReader();

            while(dataReader.Read())
            {
                ItemNota nota = new ItemNota();

                nota.Id = dataReader.GetInt32(0);
                nota.Titulo = dataReader.GetString(1);
                nota.Descripcion = dataReader.GetString(2);
                nota.wasCompleted = dataReader.GetInt16(3);

                lista.Add(nota);
            }
            comando.Connection.Close();

            return lista;
        }
    }
}
