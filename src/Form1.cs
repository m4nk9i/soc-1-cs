namespace soc_1_cs;


public partial class Form1 : Form
{
    Panel panel1;
    TextBox textbox1;

    private Manager manager1;
    public Form1()
    {        
        manager1=new Manager();
        
        InitializeComponent();
        this.panel1= new Panel();
        this.panel1.Top=10;
        this.panel1.Left=10;
        this.panel1.Width=200;
        this.panel1.Height=200;
        this.panel1.BackColor=Color.Aqua;
        this.Controls.Add(this.panel1);

        this.textbox1= new TextBox();
        this.textbox1.Top=10;
        this.textbox1.Left=220;
        this.textbox1.Width=200;
        this.textbox1.Height=200;
        this.textbox1.BackColor=Color.Aqua;
        this.textbox1.Multiline=true;
        this.Controls.Add(this.textbox1);


        manager1.mat1.Draw(this.panel1.CreateGraphics());
      //  this.t1.Draw(this.panel1.CreateGraphics());
        this.manager1.LoadPlayers(".\\data\\players.json");
        this.manager1.DumbInit();
        this.textbox1.Text+=this.manager1.t1.toStr("");
        this.textbox1.Text+=this.manager1.t2.toStr("");
      //  this.textbox1.Text+=manager1.ListPlayers();
        this.panel1.Paint+=PanelPaint;

    }

    private void PanelPaint(object? sender, PaintEventArgs e)
    {
        manager1.mat1.Draw(e.Graphics);
    }
    


    
}
