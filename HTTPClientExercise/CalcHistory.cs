using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HTTPClientExercise
{
    //displays history results from db
    public partial class CalcHistory : Form
    {
        public CalcHistory(List<CalcResults> calc)
        {
            InitializeComponent();
            dataGridView1.DataSource = calc;
        }
    }
}
