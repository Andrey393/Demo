using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Досуг.View
{
    public partial class AuthorizedForm : Form
    {
        public AuthorizedForm ( )
        {
            InitializeComponent ( );
            Class.Helper.DB = new Entity.DBEventEntities ( );
        }

        private void buttonEnter_Click ( object sender, EventArgs e )
        {
            Capcha ( );
            int number = 0;
            string password = "";
            try
            {
                number =Convert.ToInt32( textBoxNumberId.Text);
                password = textBoxPassword.Text.ToString();
            }
            catch ( Exception ex )
            {
                MessageBox.Show ( "Неправильный формат данных" );
                return;
            }

            Class.Helper.user = Class.Helper.DB.User.Where(x=>x.NumberId == number && x.Password == password).ToList().FirstOrDefault();
            if( Class.Helper.user != null )
            {
                MessageBox.Show ( "Вы вошли за пользователя: " + Class.Helper.user.FirstName + " " + Class.Helper.user.LastName + Environment.NewLine +
                    "Роль: " + Class.Helper.user.UserRole1.UserRoleName );
            }
            
        }
        void Capcha ( )
        {
            Bitmap bmp = new Bitmap ( pictureBoxCapcha.Width, pictureBoxCapcha.Height );
            Graphics g = Graphics.FromImage ( bmp );
            Random random = new Random ( );
            string captcha = "";
            for (int i = 0; i < 6; i++)
            {
                char c = (char) random.Next ( 65, 91 ); // генерация случайного символа в верхнем регистре с помощью ASCII-кодов
                captcha += c;
            }
            g.DrawString ( captcha, new Font ( "Arial", 20 ), new SolidBrush ( Color.Black ), 10, 10 );
            pictureBoxCapcha.Image = bmp;
        }

        private void AuthorizedForm_Load ( object sender, EventArgs e )
        {

        }
    }
}
