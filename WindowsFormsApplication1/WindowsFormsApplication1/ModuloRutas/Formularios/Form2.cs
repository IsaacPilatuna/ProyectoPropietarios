using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace WindowsFormsApplication1.ModuloRutas.Formularios
{
    public partial class Form2 : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        //Ruta automatizada (dirección)
        bool trazarRuta = false;
        int ContadorIndicadoresRuta = 0;
        PointLatLng inicio;
        PointLatLng final;
        public double distanciaRecorrida = 0;

        int filaSeleccionada = 0;
        double LatInicial = -0.209817;
        double LngInicial = -78.488673;
        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con.llenarData(txtUbicacion);
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //Insertando datos al dt para mostrar en la lista
            dt.Rows.Add("Ubicación 1", LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            //Desactivar las columnas
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 15;
            gMapControl1.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker); // Agregamos al mapa

            // agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", LatInicial, LngInicial);

            // Ahora agregamos el mapa y el marcador al map control
        
            gMapControl1.Overlays.Add(markerOverlay);
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void seleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex; // Fila seleccionada
            // recuperamos los datos del grid y los asignamos a los textos
            txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtLatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtLongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

            // Se asigna los valores del grid del marcador
            marker.Position = new PointLatLng(Convert.ToDouble(txtLatitud.Text), Convert.ToDouble(txtLongitud.Text));

            //se posiciona el foco del mapa en ese punto
            gMapControl1.Position = marker.Position;

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // se obtiene los datos de lat y long del mapa donde el usuario presiono

            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //se posiciona en el txt de la latitud y longitud
            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();
            //creamos el marcador para moverlo al lugar indicado
            marker.Position = new PointLatLng(lat, lng);
            //Tambien se agrega el mensaje al marcador (tooltip)
            marker.ToolTipText = string.Format("ubicacion: \n Latitud: {0} \n Longitud: {1}", lat, lng);

            CrearDireccionTrazarRuta(lat, lng);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtDescripcion.Text, txtLatitud.Text, txtLongitud.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaSeleccionada); // remover la tabla
            // procedimiento para eliminar de una base de datos
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            GMapOverlay Poligono = new GMapOverlay("Poligono");
            List<PointLatLng> puntos = new List<PointLatLng>();
            // variables para almacenar los datos
            double lng, lat;
            //Agarramos los datos del grid
            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++) 
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));

            }
            GMapPolygon poligonoPuntos = new GMapPolygon(puntos, "Polígono");
            Poligono.Polygons.Add(poligonoPuntos);
            gMapControl1.Overlays.Add(Poligono);
            // ACTUALIZAR MAPA
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            GMapOverlay Ruta = new GMapOverlay("CapaRuta");
            List<PointLatLng> puntos = new List<PointLatLng>();
            // variables para almacenar los datos
            double lng, lat;
            //Agarramos los datos del grid
            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));

            }
            GMapRoute PuntosRuta = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);
            gMapControl1.Overlays.Add(Ruta);

            // ACTUALIZAR MAPA
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        private void btnLlegar_Click(object sender, EventArgs e)
        {
            trazarRuta = true;
            btnLlegar.Enabled = false;
        }
        public double CrearDireccionTrazarRuta(double lat,double lng)
        {
            if (trazarRuta)
            {
                switch (ContadorIndicadoresRuta)
                {
                    case 0: // primer marcador o inicio
                        ContadorIndicadoresRuta++;
                        inicio = new PointLatLng(lat, lng);
                        //return 0;
                        break;
                    case 1: // segundo marcador o final
                        ContadorIndicadoresRuta++;
                        final = new PointLatLng(lat, lng);
                        GDirections direccion;

                        var RutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion,inicio,final,false,false,false,false,false);
                        GMapRoute RutaObtenida = new GMapRoute(direccion.Route, "Ruta ubicación");
                        GMapOverlay CapaRutas = new GMapOverlay("Capa de la ruta");
                        CapaRutas.Routes.Add(RutaObtenida);
                        gMapControl1.Overlays.Add(CapaRutas);
                        gMapControl1.Zoom = gMapControl1.Zoom + 1;
                        gMapControl1.Zoom = gMapControl1.Zoom - 1;
                        ContadorIndicadoresRuta = 0;
                        trazarRuta = false;
                        btnLlegar.Enabled = true;
                        distanciaRecorrida = RutaObtenida.Distance;
                        txtDistancia.Text = string.Format("{0} km",distanciaRecorrida);
                        return distanciaRecorrida;
                        break;
                }
            }
            return distanciaRecorrida;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords(txtUbicacion.Text.ToString() + ",ecuador");


        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            //distanciaRecorrida = Convert.ToInt32(txtDistancia.Text);
        }

        private void txtUbicacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
