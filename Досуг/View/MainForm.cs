using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using System.Net;
using Досуг.View;

namespace Досуг
{
    public partial class MainForm : Form
    {
        public MainForm ( )
        {
            InitializeComponent ( );
            Class.Helper.DB =new Entity.DBEventEntities();
        }
        public List<Entity.Event> ListEvents;
        string parh = Application.StartupPath;

        private void MainForm_Load ( object sender, EventArgs e )
        {
            DataLoaded ( );
        }
        void DataLoaded ( )//Проебка с list
        {
            ListEvents = Class.Helper.DB.Event.ToList ( );
            DataGridEvent.Rows.Clear ();
            int row = 0;
            string fullImage = "";
            string image = "";
            Bitmap bitmap;
            foreach (var item in ListEvents)
            {
                DataGridEvent.Rows.Add ( );

                image = item.EventPhoto;
                if(String.IsNullOrEmpty( image ) )
                {
                    //Проебка с ресурсами
                    bitmap = Properties.Resources.picture;
                }
                else
                {
                    fullImage = parh + "\\Resources\\" + image;
                    if (File.Exists ( fullImage ))
                    {
                        bitmap=new Bitmap (fullImage );
                    }
                    else
                    {
                        bitmap = Properties.Resources.picture;
                    }
                }
                DataGridEvent.Rows [row].Cells [0].Value = bitmap;

                DataGridEvent.Rows [row].Cells [1].Value ="Наименование: "+ item.EventName + Environment.NewLine;
                DataGridEvent.Rows [row].Cells [1].Value += "Направление: " + item.EventDirection + Environment.NewLine;
                DataGridEvent.Rows [row].Cells [1].Value += "Дата: " + item.EventDate + Environment.NewLine;
                DataGridEvent.Rows [row].Cells [1].Value += "Время: " + item.EventTime + Environment.NewLine;
                DataGridEvent.Rows [row].Cells [1].Value += "Продолжительность: " + item.EventDuration + Environment.NewLine;
                DataGridEvent.Rows [row].Height = 90;
                row++;
            }
        }

        private void buttonAutorized_Click ( object sender, EventArgs e )
        {
            AuthorizedForm authorizedForm = new AuthorizedForm ();
            authorizedForm.Show ( );
            this.Hide ( );
        }
    }
}
