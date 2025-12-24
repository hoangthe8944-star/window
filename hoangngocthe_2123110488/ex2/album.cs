namespace ex2
{
    public partial class album : Form
    {
        public album()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

            panelContent = new Panel();
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(186, 0);
            panelContent.Name = "panelContent";
            //panelContent.Size = new Size(614, 450);

            Controls.Add(panelContent);

        }
    }
}
