namespace soc_1_cs;

//
public partial class Form1 : Form
{
    Panel panel1;
    Button tbut1;
    TextBox textbox1;
    private TabControl tabControl;
    private TabPage tabpage1,tabpage2;

    private ListBox lb_leaugue;
    private ListBox lb_team;


    private Manager manager1;
    public Form1()
    {        
        manager1=new Manager();
        
        InitializeComponent();
        this.Text="soc 1";
       
        tbut1=new Button();
        tbut1.Left=10;
        tbut1.Top=this.Height-80;
        tbut1.Text="next round";
        tbut1.Click+=tbut1_click;
        this.Controls.Add(tbut1);
        tabControl=new TabControl();
        tabControl.Top=10;
        tabControl.Left=10;
        tabControl.Width=this.Width-30;
        tabControl.Height=this.Height-100;
        tabControl.Anchor=(AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
        tabpage1=new TabPage();
        tabpage2=new TabPage();
        tabControl.Controls.Add(tabpage1);
        tabControl.Controls.Add(tabpage2);
        this.Controls.Add(tabControl);

        this.panel1= new Panel();
        this.panel1.Top=10;
        this.panel1.Left=10;
        this.panel1.Width=200;
        this.panel1.Height=200;
        this.panel1.BackColor=Color.Aqua;
        tabpage1.Controls.Add(this.panel1);

        this.textbox1= new TextBox();
        this.textbox1.Top=10;
        this.textbox1.Left=220;
        this.textbox1.Width=300;
        this.textbox1.Height=300;
       // this.textbox1.BackColor=Color.Aqua;
        this.textbox1.Multiline=true;
        this.textbox1.ScrollBars=ScrollBars.Vertical;
        tabpage1.Controls.Add(this.textbox1);

        lb_leaugue=new ListBox();
        lb_leaugue.Top=10;
        lb_leaugue.Left=10;
        lb_leaugue.Width=200;
        lb_leaugue.Height=200;
        foreach(League tleg in manager1.l_leagues)
        {
          lb_leaugue.Items.Add(tleg.name);
        }
        lb_leaugue.SelectedIndexChanged+=lb_leaugue_index_changed;
        

        lb_team=new ListBox();
        lb_team.Top=220;
        lb_team.Left=10;
        lb_team.Width=200;
        lb_team.Height=200;
        tabpage2.Controls.Add(lb_leaugue);
        tabpage2.Controls.Add(lb_team);

        manager1.mat1.Draw(this.panel1.CreateGraphics());
      //  this.t1.Draw(this.panel1.CreateGraphics());

 //       this.manager1.DumbInit();
 //       this.textbox1.Text+=this.manager1.t1.toStr("");
  //      this.textbox1.Text+=this.manager1.t2.toStr("");
     //   this.textbox1.Text+=manager1.ListLeagues();
       // this.textbox1.Text+=manager1.tour1.OneTourMatches(1,18);
      //  manager1.mat1.Play();
      //  this.textbox1.Text+=manager1.mat1.ExtendedResult();
        //this.textbox1.Text+=manager1.l_leagues[0].NextRound();
        this.panel1.Paint+=PanelPaint;
        this.Height=600;

    }

    private void PanelPaint(object? sender, PaintEventArgs e)
    {
        manager1.mat1.Draw(e.Graphics);
    }
    
    private void lb_leaugue_index_changed(object? sender, EventArgs e)
    {
        lb_team.Items.Clear();
        foreach(Team tteam in manager1.l_leagues[lb_leaugue.SelectedIndex].l_teams)
        lb_team.Items.Add(tteam.name+" ("+tteam.points()+")") ;
    }

    private void tbut1_click(object? sender, EventArgs e)
    {
        textbox1.Text+=manager1.NextRound();
        
    }


    
}
