namespace soc_1_cs;


public partial class Form1 : Form
{
    private System.Windows.Forms.Panel panel1;
    public Match mat1;
    public Team t1;
    public Form1()
    {        
        mat1=new Match();
        t1=new Team();
        InitializeComponent();
        this.panel1= new Panel();
        this.panel1.Top=10;
        this.panel1.Left=10;
        this.panel1.Width=200;
        this.panel1.Height=200;
        this.panel1.BackColor=Color.Aqua;
        this.Controls.Add(this.panel1);
        this.mat1.Draw(this.panel1.CreateGraphics());
      //  this.t1.Draw(this.panel1.CreateGraphics());
        this.panel1.Paint+=PanelPaint;

    }

    private void PanelPaint(object sender, PaintEventArgs e)
    {
        this.mat1.Draw(e.Graphics);
    }
    


    
}
