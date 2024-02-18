namespace Iteration_WorkShop
{
    public partial class Form1_Iterations : System.Windows.Forms.Form
    {
        private float originalFontSize, originalFormWidth, originalFormHeight;
        public Form1_Iterations()
        {
            InitializeComponent();

            #region hantering av font och vilka controler som visas 
            originalFontSize = lbl_Heading_Foreach.Font.Size; // alla heading är samma ursprungliga storlek, en räcker som referens
            originalFormWidth = this.ClientSize.Width;
            originalFormHeight = this.ClientSize.Height;
            this.Resize += new EventHandler(Form_Resize);
            btn_Close_DoWhile.Visible = false;
            btn_Close_For.Visible = false;
            btn_Close_ForEach.Visible = false;
            listBox_DoWhile.Visible = false;
            listBox_For.Visible = false;
            listBox_ForEach.Visible = false;
            txtBox_While1.Enter += txtBox_While1_Enter;
            #endregion
        }

        #region Responsiv hantering av rubrikernas font
        private void Form_Resize(object? sender, EventArgs e)
        {
            float scaleFactor = Math.Max(this.Width / (float)originalFormWidth, this.Height / (float)originalFormHeight);
            lbl_Heading_While.Font = new Font(lbl_Heading_While.Font.FontFamily, originalFontSize * scaleFactor, lbl_Heading_While.Font.Style);
            lbl_Heading_DoWhile.Font = new Font(lbl_Heading_DoWhile.Font.FontFamily, originalFontSize * scaleFactor, lbl_Heading_DoWhile.Font.Style);
            lbl_Heading_For.Font = new Font(lbl_Heading_For.Font.FontFamily, originalFontSize * scaleFactor, lbl_Heading_For.Font.Style);
            lbl_Heading_Foreach.Font = new Font(lbl_Heading_Foreach.Font.FontFamily, originalFontSize * scaleFactor, lbl_Heading_Foreach.Font.Style);
        }

        #endregion

        private void btn_While1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBox_While1.Text, out int ok))
            {
                MessageBox.Show("Vänligen ange ett heltal i rutan \"Värde 1\" för While", "Felaktig inmatning");
                return;
            }
            txtBox_While1.Text = "Värde 1";
            txtBox_While1.ForeColor = Color.Gray;
            txtBox_While2.Text = "Värde 2";
            txtBox_While2.ForeColor = Color.Gray;

            btn_Close_While.Visible = true;
            listBox_While.Visible = true;
        }

        private void btn_While2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBox_While1.Text) || String.IsNullOrEmpty(txtBox_While2.Text) || txtBox_While1.Text == "Värde 1" || txtBox_While2.Text == "Värde 2")
            {
                MessageBox.Show("Ange ett namn i rutan \"Värde 1\" och ett lösenord för \"Värde 2\" under While", "Felaktig inmatning");
                return;
            }
            txtBox_While1.Text = "Värde 1";
            txtBox_While1.ForeColor = Color.Gray;
            txtBox_While2.Text = "Värde 2";
            txtBox_While2.ForeColor = Color.Gray;

            btn_Close_While.Visible = true;
            listBox_While.Visible = true;
        }

        private void btn_DoWhile1_Click(object sender, EventArgs e)
        {
            btn_Close_DoWhile.Visible = true;
            listBox_DoWhile.Visible = true;
        }

        private void btn_DoWhile2_Click(object sender, EventArgs e)
        {
            btn_Close_DoWhile.Visible = true;
            listBox_DoWhile.Visible = true;
        }

        private void btn_For1_Click(object sender, EventArgs e)
        {
            btn_Close_For.Visible = true;
            listBox_For.Visible = true;
        }

        private void btn_For2_Click(object sender, EventArgs e)
        {
            btn_Close_For.Visible = true;
            listBox_For.Visible = true;
        }

        private void btn_ForEach1_Click(object sender, EventArgs e)
        {
            btn_Close_ForEach.Visible = true;
            listBox_ForEach.Visible = true;
        }

        private void btn_ForEach2_Click(object sender, EventArgs e)
        {
            btn_Close_ForEach.Visible = true;
            listBox_ForEach.Visible = true;
        }

        private void btn_Close_While_Click(object sender, EventArgs e)
        {
            btn_Close_While.Visible = false;
            listBox_While.Visible = false;
            listBox_While.Items.Clear();
        }

        private void btn_Close_DoWhile_Click(object sender, EventArgs e)
        {
            btn_Close_DoWhile.Visible = false;
            listBox_DoWhile.Visible = false;
            listBox_DoWhile.Items.Clear();
        }

        private void btn_Close_For_Click(object sender, EventArgs e)
        {
            btn_Close_For.Visible = false;
            listBox_For.Visible = false;
            listBox_For.Items.Clear();
        }

        private void btn_Close_ForEach_Click(object sender, EventArgs e)
        {
            btn_Close_ForEach.Visible = false;
            listBox_ForEach.Visible = false;
            listBox_ForEach.Items.Clear();
        }

        private void txtBox_While1_Enter(object sender, EventArgs e)
        {
            if (txtBox_While1.Text == "Värde 1")
            {
                txtBox_While1.Text = "";
                txtBox_While1.ForeColor = Color.Black;
            }
        }

        private void txtBox_While2_Enter(object sender, EventArgs e)
        {
            if (txtBox_While2.Text == "Värde 2")
            {
                txtBox_While2.Text = "";
                txtBox_While2.ForeColor = Color.Black;
            }
        }
    }
}